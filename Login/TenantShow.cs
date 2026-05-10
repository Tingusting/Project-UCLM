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
    public partial class TenantShow : Form
    {
        string filePath = "rooms.json";
        List<RoomInfo> rooms = new List<RoomInfo>();
        public TenantShow()
        {
            InitializeComponent();
        }

        private void TenantShow_Load(object sender, EventArgs e)
        {
            LoadRooms();
            DisplayTenants();
        }
        private void LoadRooms()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                rooms = JsonSerializer.Deserialize<List<RoomInfo>>(json)
                        ?? new List<RoomInfo>();
            }
        }

        private void DisplayTenants()
        {
            listBox1.Items.Clear();

            var tenants = rooms
                .Where(r => !r.IsAvailable &&
                            !string.IsNullOrEmpty(r.TenantName))
                .ToList();

            foreach (var room in tenants)
            {
                listBox1.Items.Add(
                    $"Room: {room.RoomNumber}"
                );

                listBox1.Items.Add(
                    $"Name: {room.TenantName}"
                );

                listBox1.Items.Add(
                    $"Age: {room.Age}"
                );

                listBox1.Items.Add(
                    $"Contact: {room.ContactNumber}"
                );

                listBox1.Items.Add(
                    $"Address: {room.Address}"
                );

                listBox1.Items.Add(
                    $"Valid ID: {room.ValidID}"
                );

                listBox1.Items.Add(
                    "--------------------------"
                );
            }
        }
    }
}
