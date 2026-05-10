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
            listBoxTenants = new ListBox();
            button2 = new Button();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            numAge = new NumericUpDown();
            txtTenantName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            cmbValidID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
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
            // listBoxTenants
            // 
            listBoxTenants.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBoxTenants.FormattingEnabled = true;
            listBoxTenants.ItemHeight = 38;
            listBoxTenants.Location = new Point(12, 21);
            listBoxTenants.Name = "listBoxTenants";
            listBoxTenants.Size = new Size(357, 308);
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
            // txtAddress
            // 
            txtAddress.Location = new Point(488, 231);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(352, 34);
            txtAddress.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(488, 173);
            txtContact.Multiline = true;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(352, 34);
            txtContact.TabIndex = 7;
            // 
            // numAge
            // 
            numAge.Location = new Point(589, 117);
            numAge.Name = "numAge";
            numAge.Size = new Size(145, 27);
            numAge.TabIndex = 6;
            // 
            // txtTenantName
            // 
            txtTenantName.Location = new Point(488, 56);
            txtTenantName.Multiline = true;
            txtTenantName.Name = "txtTenantName";
            txtTenantName.Size = new Size(352, 34);
            txtTenantName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 124);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 11;
            label2.Text = "Age";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 176);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 12;
            label3.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 234);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 298);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 15;
            label6.Text = "ValidID";
            // 
            // cmbValidID
            // 
            cmbValidID.FormattingEnabled = true;
            cmbValidID.Items.AddRange(new object[] { "Philippine Identification (PhilID/ePhilID)", "Passport", "Driver's License", "UMID", "PRC ID", "SSS ID", "Senior Citizen", "PWD", "Voter's/COMELEC", "Postal ID" });
            cmbValidID.Location = new Point(488, 301);
            cmbValidID.Name = "cmbValidID";
            cmbValidID.Size = new Size(352, 28);
            cmbValidID.TabIndex = 16;
            // 
            // Tenant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 697);
            Controls.Add(cmbValidID);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(numAge);
            Controls.Add(txtTenantName);
            Controls.Add(button2);
            Controls.Add(listBoxTenants);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tenant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tenant";
            Load += Tenant_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBoxTenants;
        private Button button2;
        private TextBox txtAddress;
        private TextBox txtContact;
        private NumericUpDown numAge;
        private TextBox txtTenantName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox cmbValidID;
    }
}