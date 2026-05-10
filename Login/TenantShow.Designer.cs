namespace Login
{
    partial class TenantShow
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
            listBox1 = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(360, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(570, 346);
            listBox1.TabIndex = 0;
            // 
            // TenantShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 697);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TenantShow";
            Text = "TenantShow";
            Load += TenantShow_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}