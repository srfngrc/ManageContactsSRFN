namespace ContactManagerSRFN
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBLfirstname = new System.Windows.Forms.Label();
            this.LBLlastname = new System.Windows.Forms.Label();
            this.LBLphone = new System.Windows.Forms.Label();
            this.LBLmail = new System.Windows.Forms.Label();
            this.TBfirstname = new System.Windows.Forms.TextBox();
            this.TBlastname = new System.Windows.Forms.TextBox();
            this.TBphone = new System.Windows.Forms.TextBox();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(61, 54);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone});
            this.dgContacts.Location = new System.Drawing.Point(12, 99);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.Size = new System.Drawing.Size(545, 194);
            this.dgContacts.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email Addr";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone Nbr";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // LBLfirstname
            // 
            this.LBLfirstname.AutoSize = true;
            this.LBLfirstname.Location = new System.Drawing.Point(51, 330);
            this.LBLfirstname.Name = "LBLfirstname";
            this.LBLfirstname.Size = new System.Drawing.Size(54, 13);
            this.LBLfirstname.TabIndex = 2;
            this.LBLfirstname.Text = "FirstName";
            // 
            // LBLlastname
            // 
            this.LBLlastname.AutoSize = true;
            this.LBLlastname.Location = new System.Drawing.Point(51, 359);
            this.LBLlastname.Name = "LBLlastname";
            this.LBLlastname.Size = new System.Drawing.Size(55, 13);
            this.LBLlastname.TabIndex = 3;
            this.LBLlastname.Text = "LastName";
            // 
            // LBLphone
            // 
            this.LBLphone.AutoSize = true;
            this.LBLphone.Location = new System.Drawing.Point(51, 386);
            this.LBLphone.Name = "LBLphone";
            this.LBLphone.Size = new System.Drawing.Size(38, 13);
            this.LBLphone.TabIndex = 4;
            this.LBLphone.Text = "Phone";
            // 
            // LBLmail
            // 
            this.LBLmail.AutoSize = true;
            this.LBLmail.Location = new System.Drawing.Point(51, 412);
            this.LBLmail.Name = "LBLmail";
            this.LBLmail.Size = new System.Drawing.Size(32, 13);
            this.LBLmail.TabIndex = 5;
            this.LBLmail.Text = "Email";
            // 
            // TBfirstname
            // 
            this.TBfirstname.Location = new System.Drawing.Point(135, 322);
            this.TBfirstname.Name = "TBfirstname";
            this.TBfirstname.Size = new System.Drawing.Size(100, 20);
            this.TBfirstname.TabIndex = 6;
            // 
            // TBlastname
            // 
            this.TBlastname.Location = new System.Drawing.Point(135, 352);
            this.TBlastname.Name = "TBlastname";
            this.TBlastname.Size = new System.Drawing.Size(100, 20);
            this.TBlastname.TabIndex = 7;
            // 
            // TBphone
            // 
            this.TBphone.Location = new System.Drawing.Point(135, 383);
            this.TBphone.Name = "TBphone";
            this.TBphone.Size = new System.Drawing.Size(100, 20);
            this.TBphone.TabIndex = 8;
            // 
            // TBmail
            // 
            this.TBmail.Location = new System.Drawing.Point(135, 412);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(100, 20);
            this.TBmail.TabIndex = 9;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(98, 444);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 479);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.TBmail);
            this.Controls.Add(this.TBphone);
            this.Controls.Add(this.TBlastname);
            this.Controls.Add(this.TBfirstname);
            this.Controls.Add(this.LBLmail);
            this.Controls.Add(this.LBLphone);
            this.Controls.Add(this.LBLlastname);
            this.Controls.Add(this.LBLfirstname);
            this.Controls.Add(this.dgContacts);
            this.Controls.Add(this.lblMessage);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Label LBLfirstname;
        private System.Windows.Forms.Label LBLlastname;
        private System.Windows.Forms.Label LBLphone;
        private System.Windows.Forms.Label LBLmail;
        private System.Windows.Forms.TextBox TBfirstname;
        private System.Windows.Forms.TextBox TBlastname;
        private System.Windows.Forms.TextBox TBphone;
        private System.Windows.Forms.TextBox TBmail;
        private System.Windows.Forms.Button btnAddNew;
    }
}