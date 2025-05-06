namespace GUI.ChildForms
{
    partial class frmContractInfo
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
            this.cbRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.txtRentPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContractID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenant = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTienCoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRoom
            // 
            this.cbRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbRoom.BorderColor = System.Drawing.Color.Black;
            this.cbRoom.BorderRadius = 10;
            this.cbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRoom.ForeColor = System.Drawing.Color.Black;
            this.cbRoom.ItemHeight = 30;
            this.cbRoom.Location = new System.Drawing.Point(155, 108);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(305, 36);
            this.cbRoom.TabIndex = 1;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(17, 117);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(67, 25);
            this.lblRoom.TabIndex = 53;
            this.lblRoom.Text = "Phòng";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(155, 502);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 45);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.BorderColor = System.Drawing.Color.Black;
            this.txtRentPrice.BorderRadius = 10;
            this.txtRentPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentPrice.DefaultText = "";
            this.txtRentPrice.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtRentPrice.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtRentPrice.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtRentPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtRentPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRentPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentPrice.Location = new System.Drawing.Point(155, 240);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.PlaceholderText = "";
            this.txtRentPrice.SelectedText = "";
            this.txtRentPrice.Size = new System.Drawing.Size(305, 41);
            this.txtRentPrice.TabIndex = 4;
            // 
            // txtContractID
            // 
            this.txtContractID.BorderColor = System.Drawing.Color.Black;
            this.txtContractID.BorderRadius = 10;
            this.txtContractID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContractID.DefaultText = "";
            this.txtContractID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContractID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContractID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContractID.Enabled = false;
            this.txtContractID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtContractID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractID.ForeColor = System.Drawing.Color.Black;
            this.txtContractID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContractID.Location = new System.Drawing.Point(155, 20);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.PlaceholderText = "";
            this.txtContractID.SelectedText = "";
            this.txtContractID.Size = new System.Drawing.Size(305, 36);
            this.txtContractID.TabIndex = 39;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(17, 247);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(84, 25);
            this.lblCCCD.TabIndex = 52;
            this.lblCCCD.Text = "Giá thuê";
            this.lblCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày bắt đầu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã hợp đồng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Khách thuê";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "Thông tin Hợp đồng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTenant
            // 
            this.cbTenant.BackColor = System.Drawing.Color.Transparent;
            this.cbTenant.BorderColor = System.Drawing.Color.Black;
            this.cbTenant.BorderRadius = 10;
            this.cbTenant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenant.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenant.ForeColor = System.Drawing.Color.Black;
            this.cbTenant.ItemHeight = 30;
            this.cbTenant.Location = new System.Drawing.Point(155, 65);
            this.cbTenant.Name = "cbTenant";
            this.cbTenant.Size = new System.Drawing.Size(305, 36);
            this.cbTenant.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 10;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(155, 150);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(305, 36);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Value = new System.DateTime(2025, 4, 13, 15, 26, 50, 225);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BorderColor = System.Drawing.Color.Black;
            this.txtTienCoc.BorderRadius = 10;
            this.txtTienCoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienCoc.DefaultText = "";
            this.txtTienCoc.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtTienCoc.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTienCoc.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtTienCoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTienCoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.ForeColor = System.Drawing.Color.Black;
            this.txtTienCoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienCoc.Location = new System.Drawing.Point(155, 287);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.PlaceholderText = "";
            this.txtTienCoc.SelectedText = "";
            this.txtTienCoc.Size = new System.Drawing.Size(305, 41);
            this.txtTienCoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tiền cọc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 60;
            this.label7.Text = "Ghi chú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(155, 341);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(305, 145);
            this.txtNote.TabIndex = 6;
            this.txtNote.Text = "";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 10;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(155, 192);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(305, 36);
            this.dtpEndDate.TabIndex = 61;
            this.dtpEndDate.Value = new System.DateTime(2025, 4, 13, 15, 26, 50, 225);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Ngày hết hạn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 18);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(499, 80);
            this.guna2Panel1.TabIndex = 63;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.cbRoom);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.btnConfirm);
            this.guna2Panel2.Controls.Add(this.dtpEndDate);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.txtNote);
            this.guna2Panel2.Controls.Add(this.lblCCCD);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.txtContractID);
            this.guna2Panel2.Controls.Add(this.txtTienCoc);
            this.guna2Panel2.Controls.Add(this.txtRentPrice);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.lblRoom);
            this.guna2Panel2.Controls.Add(this.dtpStartDate);
            this.guna2Panel2.Controls.Add(this.cbTenant);
            this.guna2Panel2.Location = new System.Drawing.Point(20, 121);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(499, 561);
            this.guna2Panel2.TabIndex = 64;
            // 
            // frmContractInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(531, 708);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.MaximizeBox = false;
            this.Name = "frmContractInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin hợp đồng";
            this.Load += new System.EventHandler(this.frmContractInfo_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbRoom;
        private System.Windows.Forms.Label lblRoom;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtRentPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtContractID;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenant;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTienCoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtNote;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}