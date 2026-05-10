namespace Login
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnRefresh = new Button();
            btnReload = new Button();
            lblTotalRooms = new Label();
            lblOccupiedRooms = new Label();
            lblAvailableRooms = new Label();
            lblTotalTenants = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(75, 495);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 43);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(311, 495);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(122, 43);
            btnReload.TabIndex = 1;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // lblTotalRooms
            // 
            lblTotalRooms.AutoSize = true;
            lblTotalRooms.Location = new Point(311, 73);
            lblTotalRooms.Name = "lblTotalRooms";
            lblTotalRooms.Size = new Size(50, 20);
            lblTotalRooms.TabIndex = 2;
            lblTotalRooms.Text = "label1";
            // 
            // lblOccupiedRooms
            // 
            lblOccupiedRooms.AutoSize = true;
            lblOccupiedRooms.Location = new Point(311, 140);
            lblOccupiedRooms.Name = "lblOccupiedRooms";
            lblOccupiedRooms.Size = new Size(50, 20);
            lblOccupiedRooms.TabIndex = 3;
            lblOccupiedRooms.Text = "label2";
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Location = new Point(311, 197);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(50, 20);
            lblAvailableRooms.TabIndex = 4;
            lblAvailableRooms.Text = "label3";
            // 
            // lblTotalTenants
            // 
            lblTotalTenants.AutoSize = true;
            lblTotalTenants.Location = new Point(311, 267);
            lblTotalTenants.Name = "lblTotalTenants";
            lblTotalTenants.Size = new Size(50, 20);
            lblTotalTenants.TabIndex = 5;
            lblTotalTenants.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 73);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 6;
            label1.Text = "Total Rooms:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 140);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 7;
            label2.Text = "Occupied Rooms:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 197);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Available Rooms:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 267);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 9;
            label4.Text = "Total Tenants:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(552, 73);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(618, 465);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 697);
            Controls.Add(chart1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalTenants);
            Controls.Add(lblAvailableRooms);
            Controls.Add(lblOccupiedRooms);
            Controls.Add(lblTotalRooms);
            Controls.Add(btnReload);
            Controls.Add(btnRefresh);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnReload;
        private Label lblTotalRooms;
        private Label lblOccupiedRooms;
        private Label lblAvailableRooms;
        private Label lblTotalTenants;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}