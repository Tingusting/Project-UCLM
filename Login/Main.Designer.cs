namespace Login
{
    partial class Main
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
            panel2 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            button2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1365, 74);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1282, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 57);
            button1.TabIndex = 2;
            button1.Text = "【﻿\u23fb】";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 697);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 40);
            label1.TabIndex = 7;
            label1.Text = "Menu";
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSlateBlue;
            button5.Location = new Point(3, 106);
            button5.Name = "button5";
            button5.Size = new Size(143, 73);
            button5.TabIndex = 6;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.Location = new Point(3, 269);
            button4.Name = "button4";
            button4.Size = new Size(143, 73);
            button4.TabIndex = 5;
            button4.Text = "Tenants";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.Location = new Point(3, 185);
            button3.Name = "button3";
            button3.Size = new Size(143, 73);
            button3.TabIndex = 4;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(152, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 697);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(406, 195);
            label2.Name = "label2";
            label2.Size = new Size(179, 40);
            label2.TabIndex = 8;
            label2.Text = "GOOD DAY!";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(3, 9);
            button2.Name = "button2";
            button2.Size = new Size(80, 57);
            button2.TabIndex = 3;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 769);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}