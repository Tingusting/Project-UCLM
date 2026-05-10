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

namespace Login
{
    public partial class Main : Form
    {
        List<RoomInfo> rooms = new List<RoomInfo>();
        string filePath = "rooms.json";
        public Main()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Room());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new TenantShow());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
        private void LoadRooms()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                rooms = JsonSerializer.Deserialize<List<RoomInfo>>(json);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ask confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Open login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close current form (Dashboard / Main)
                this.Hide();
            }
        }
    }
}
