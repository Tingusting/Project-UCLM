namespace Login
{
    partial class Tenant
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
            button1 = new Button();
            txtTenantName = new TextBox();
            listBoxTenants = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(620, 522);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTenantName
            // 
            txtTenantName.Location = new Point(531, 441);
            txtTenantName.Multiline = true;
            txtTenantName.Name = "txtTenantName";
            txtTenantName.Size = new Size(284, 45);
            txtTenantName.TabIndex = 1;
            // 
            // listBoxTenants
            // 
            listBoxTenants.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxTenants.FormattingEnabled = true;
            listBoxTenants.ItemHeight = 37;
            listBoxTenants.Location = new Point(338, 66);
            listBoxTenants.Name = "listBoxTenants";
            listBoxTenants.Size = new Size(630, 337);
            listBoxTenants.TabIndex = 3;
            listBoxTenants.SelectedIndexChanged += listBoxTenants_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1122, 3);
            button2.Name = "button2";
            button2.Size = new Size(85, 42);
            button2.TabIndex = 4;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tenant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 697);
            Controls.Add(button2);
            Controls.Add(listBoxTenants);
            Controls.Add(txtTenantName);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tenant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tenant";
            Load += Tenant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTenantName;
        private ListBox listBoxTenants;
        private Button button2;
    }
}