namespace Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 714);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSlateBlue;
            button5.Location = new Point(3, 274);
            button5.Name = "button5";
            button5.Size = new Size(143, 73);
            button5.TabIndex = 6;
            button5.Text = "Report";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.Location = new Point(3, 195);
            button4.Name = "button4";
            button4.Size = new Size(143, 73);
            button4.TabIndex = 5;
            button4.Text = "Tenants";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.Location = new Point(3, 116);
            button3.Name = "button3";
            button3.Size = new Size(143, 73);
            button3.TabIndex = 4;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.Location = new Point(3, 37);
            button2.Name = "button2";
            button2.Size = new Size(143, 73);
            button2.TabIndex = 3;
            button2.Text = "Menu";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1365, 63);
            panel2.TabIndex = 1;
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
            // 
            // panel3
            // 
            panel3.Location = new Point(149, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(1214, 697);
            panel3.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1363, 769);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Main";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel3;
    }
}
