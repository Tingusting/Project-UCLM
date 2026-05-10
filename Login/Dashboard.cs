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
using System.Windows.Forms.DataVisualization.Charting;

namespace Login
{
    public partial class Dashboard : Form
    {
        private string filePath = "rooms.json";
        private List<RoomInfo> rooms = new List<RoomInfo>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadStats();
            LoadChart();
        }
        // =========================
        // 📥 LOAD JSON DATA
        // =========================
        private void LoadRooms()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                rooms = JsonSerializer.Deserialize<List<RoomInfo>>(json)
                         ?? new List<RoomInfo>();
            }
            else
            {
                rooms = new List<RoomInfo>();
            }
        }

        // =========================
        // 📊 COMPUTE STATISTICS
        // =========================
        private void LoadStats()
        {
            int totalRooms = rooms.Count;

            int occupiedRooms = rooms.Count(r => !r.IsAvailable);

            int availableRooms = rooms.Count(r => r.IsAvailable);

            int totalTenants = rooms.Count(r =>
                !string.IsNullOrEmpty(r.TenantName));

            // =========================
            // 🧾 DISPLAY TO LABELS
            // =========================
            lblTotalRooms.Text = totalRooms.ToString();
            lblOccupiedRooms.Text = occupiedRooms.ToString();
            lblAvailableRooms.Text = availableRooms.ToString();
            lblTotalTenants.Text = totalTenants.ToString();
        }
        private void LoadChart()
        {
            // Clear old data
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Create chart title
            chart1.Titles.Add("Room Status Overview");

            // Create series
            Series series = new Series("Rooms");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Arial", 10, FontStyle.Bold);

            // Data
            int occupiedRooms = rooms.Count(r => !r.IsAvailable);
            int availableRooms = rooms.Count(r => r.IsAvailable);

            // Add points
            series.Points.AddXY("Occupied", occupiedRooms);
            series.Points.AddXY("Available", availableRooms);

            // Colors
            series.Points[0].Color = Color.Red;
            series.Points[1].Color = Color.Green;

            // Add series to chart
            chart1.Series.Add(series);

            // Legend
            chart1.Legends[0].Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRooms();
            LoadStats();
            LoadChart();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadRooms();
            LoadStats();
            LoadChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
