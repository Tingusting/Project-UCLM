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
    public partial class Report : Form
    {
        private List<RoomInfo> rooms;
        string filePath = Path.Combine(Application.StartupPath, "rooms.json");
     
        public Report()
        {
            InitializeComponent();
           
        }
        private void Report_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadChartData();
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
                rooms = new List<RoomInfo>();
            }
        }
        private void LoadChartData()
        {
            chart1.Series.Clear(); // ✅ USE DESIGNER CHART

            Series series = new Series("Customers");
            series.ChartType = SeriesChartType.Column;

            foreach (var room in rooms.OrderByDescending(r => r.TotalCustomers))
            {
                series.Points.AddXY($"Room {room.RoomNumber}", room.TotalCustomers);
            }

            chart1.Series.Add(series);
        }
    }
}
