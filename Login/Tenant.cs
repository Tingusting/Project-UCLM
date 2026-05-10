using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Login
{

    public partial class Tenant : Form
    {
        private Main mainForm;
        string filePath = "rooms.json";
        public string TenantName { get; private set; }
        private List<RoomInfo> rooms;


        public int TenantAge { get; private set; }

        public string ContactNumber { get; private set; }

        public string Address { get; private set; }

        public string ValidID { get; private set; }
        public Tenant(List<RoomInfo> roomList)
        {
            InitializeComponent();
            rooms = roomList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenantName.Text))
            {
                // SAVE TENANT INFO
                TenantName = txtTenantName.Text;

                TenantAge = (int)numAge.Value;

                ContactNumber = txtContact.Text;

                Address = txtAddress.Text;

                ValidID = cmbValidID.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter tenant name.");
            }
        }

        private void listBoxTenants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTenants.SelectedItem != null)
            {
                txtTenantName.Text = listBoxTenants.SelectedItem.ToString();
            }
        }

        private void Tenant_Load(object sender, EventArgs e)
        {
            LoadRooms();        // load latest data first
            LoadTenantNames();
        }
        private void LoadTenantNames()
        {
            listBoxTenants.Items.Clear();

            var tenants = rooms
                .Where(r => !r.IsAvailable && !string.IsNullOrEmpty(r.TenantName))
                .Select(r => $"Room {r.RoomNumber} - {r.TenantName}")
                .ToList();

            foreach (var t in tenants)
            {
                listBoxTenants.Items.Add(t);
            }
        }
        private void LoadRooms()
        {
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                rooms = System.Text.Json.JsonSerializer.Deserialize<List<RoomInfo>>(json)
                        ?? new List<RoomInfo>();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadRooms();        // reload latest data
            LoadTenantNames();
        }

        private void txtTenantName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
