using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Login
{
    public partial class Room : Form
    {
        List<RoomInfo> rooms = new List<RoomInfo>();
        string filePath = Path.Combine(Application.StartupPath, "rooms.json");
        System.Windows.Forms.Timer dueTimer = new System.Windows.Forms.Timer();
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadRooms();
            CreateRoomButtons();

            SetupDuePanel();
            UpdateDuePanel();
            // ✅ timer setup
            dueTimer.Interval = 1000;
            dueTimer.Tick += timer1_Tick;
            dueTimer.Start();

        }
        private void LoadRooms()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                rooms = JsonSerializer.Deserialize<List<RoomInfo>>(json) ?? new List<RoomInfo>();
            }
            else
            {
                rooms = new List<RoomInfo>
                {
                    new RoomInfo { RoomNumber = 101, IsAvailable = true },
                    new RoomInfo { RoomNumber = 102, IsAvailable = true },
                    new RoomInfo { RoomNumber = 103, IsAvailable = true },
                    new RoomInfo { RoomNumber = 104, IsAvailable = true },
                    new RoomInfo { RoomNumber = 105, IsAvailable = true },
                    new RoomInfo { RoomNumber = 106, IsAvailable = true },
                    new RoomInfo { RoomNumber = 107, IsAvailable = true },
                    new RoomInfo { RoomNumber = 108, IsAvailable = true },
                    new RoomInfo { RoomNumber = 109, IsAvailable = true }
                };

                SaveRooms();
            }
        }
        private void SaveRooms()
        {
            string json = JsonSerializer.Serialize(rooms, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        private void CreateRoomButtons()
        {
            // Remove old buttons only
            foreach (Control c in this.Controls.OfType<Button>().ToList())
            {
                this.Controls.Remove(c);
            }

            int buttonWidth = 180;
            int buttonHeight = 100;
            int spacing = 20;

            int cols = 3;
            int rowsGrid = 3;

            int totalWidth = (buttonWidth * cols) + (spacing * (cols - 1));
            int totalHeight = (buttonHeight * rowsGrid) + (spacing * (rowsGrid - 1));

            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            int index = 0;

            for (int r = 0; r < rowsGrid; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (index >= rooms.Count)
                        break;

                    var room = rooms[index];

                    Button btn = new Button();

                    btn.Width = buttonWidth;
                    btn.Height = buttonHeight;

                    btn.Left = startX + c * (buttonWidth + spacing);
                    btn.Top = startY + r * (buttonHeight + spacing);

                    btn.Tag = room;

                    string timerText = "";

                    // SHOW COUNTDOWN
                    if (!room.IsAvailable && room.DueDate.HasValue)
                    {
                        TimeSpan remaining =
                            room.DueDate.Value - DateTime.Now;

                        if (remaining.TotalSeconds > 0)
                        {
                            timerText =
                                $"{remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
                        }
                        else
                        {
                            timerText = "DUE";
                        }
                    }

                    btn.Text = room.IsAvailable
                        ? $"Room {room.RoomNumber}\nAvailable"
                        : $"Room {room.RoomNumber}\n{room.TenantName}\n{timerText}";

                    btn.Font = new Font("Arial", 10, FontStyle.Bold);

                    UpdateButtonColor(btn, room);

                    btn.Click += RoomButton_Click;

                    this.Controls.Add(btn);

                    index++;
                }
            }
        }
        private void UpdateButtonColor(Button btn, RoomInfo room)
        {
            if (room.IsAvailable)
            {
                btn.BackColor = Color.LightGreen;
            }
            else if (room.DueDate.HasValue && room.DueDate.Value.Date <= DateTime.Now.Date)
            {
                btn.BackColor = Color.OrangeRed; // DUE
            }
            else
            {
                btn.BackColor = Color.LightCoral;
            }
        }
        private void RoomButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            RoomInfo room = (RoomInfo)btn.Tag;

            if (room.IsAvailable)
            {
                // Open Tenant Form
                Tenant form = new Tenant(rooms);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    room.IsAvailable = false;

                    room.TenantName = form.TenantName;

                    room.Age = form.TenantAge;

                    room.ContactNumber = form.ContactNumber;

                    room.Address = form.Address;

                    room.ValidID = form.ValidID;

                    room.DueDate = DateTime.Now.AddHours(24);

                    room.IsNotified = false;

                    room.TotalCustomers++;

                    SaveRooms();

                    CreateRoomButtons();

                    UpdateDuePanel();
                }
            }
            else
            {
                room.IsAvailable = true;
                room.TenantName = "";
                room.DueDate = null;
                room.IsNotified = false;

                SaveRooms();
                CreateRoomButtons();
                UpdateDuePanel();
            }
            // ✅ NOTIFICATION SYSTEM

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDuePanel();
        }
        // =========================
        // DUE PANEL UI
        // =========================
        ListBox lstDueRooms = new ListBox();
        Panel panelDue = new Panel();

        private void SetupDuePanel()
        {
            panelDue.Width = 250;
            panelDue.Dock = DockStyle.Right;
            panelDue.BackColor = Color.WhiteSmoke;

            lstDueRooms.Dock = DockStyle.Fill;
            lstDueRooms.Font = new Font("Arial", 10, FontStyle.Regular);

            panelDue.Controls.Add(lstDueRooms);
            this.Controls.Add(panelDue);
            panelDue.BringToFront();
        }

        private void UpdateDuePanel()
        {
            lstDueRooms.Items.Clear();

            foreach (var room in rooms)
            {
                if (!room.IsAvailable && room.DueDate.HasValue)
                {
                    if (room.DueDate.Value.Date <= DateTime.Now.Date)
                    {
                        lstDueRooms.Items.Add(
                            $"Room {room.RoomNumber} - {room.TenantName} (DUE)"
                        );
                    }
                }
            }

            if (lstDueRooms.Items.Count == 0)
            {
                lstDueRooms.Items.Add("No due rooms today ✔");
            }
        }
    }
}
