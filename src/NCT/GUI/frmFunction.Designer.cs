namespace GUI
{
    partial class frmFunction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTypeList = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhi = new System.Windows.Forms.Label();
            this.cbPhi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new FontAwesome.Sharp.IconButton();
            this.panel = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeList
            // 
            this.lblTypeList.AutoSize = true;
            this.lblTypeList.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeList.Location = new System.Drawing.Point(13, 7);
            this.lblTypeList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeList.Name = "lblTypeList";
            this.lblTypeList.Size = new System.Drawing.Size(132, 40);
            this.lblTypeList.TabIndex = 0;
            this.lblTypeList.Text = "Type List";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(172, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(765, 44);
            this.txtSearch.TabIndex = 4;
            // 
            // lblPhi
            // 
            this.lblPhi.AutoSize = true;
            this.lblPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhi.Location = new System.Drawing.Point(299, 25);
            this.lblPhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(105, 21);
            this.lblPhi.TabIndex = 3;
            this.lblPhi.Text = "Trạng thái phí";
            // 
            // cbPhi
            // 
            this.cbPhi.BackColor = System.Drawing.Color.Transparent;
            this.cbPhi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.cbPhi.BorderRadius = 5;
            this.cbPhi.BorderThickness = 2;
            this.cbPhi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhi.ItemHeight = 30;
            this.cbPhi.Location = new System.Drawing.Point(304, 54);
            this.cbPhi.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhi.Name = "cbPhi";
            this.cbPhi.Size = new System.Drawing.Size(239, 36);
            this.cbPhi.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(35, 25);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 21);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trạng thái phòng";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.cbStatus.BorderRadius = 5;
            this.cbStatus.BorderThickness = 2;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Location = new System.Drawing.Point(40, 54);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(239, 36);
            this.cbStatus.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoScroll = true;
            this.guna2Panel3.Controls.Add(this.dgv);
            this.guna2Panel3.Location = new System.Drawing.Point(16, 70);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1428, 615);
            this.guna2Panel3.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(225)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 50;
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1428, 615);
            this.dgv.TabIndex = 3;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(225)))));
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(190)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 40;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.btnSearch);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnEdit);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Controls.Add(this.btnInsert);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(20, 208);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1463, 703);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(16, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(139, 44);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 20;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1291, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(153, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 20;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1129, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(153, 44);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnInsert.IconColor = System.Drawing.Color.Black;
            this.btnInsert.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnInsert.IconSize = 20;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(960, 15);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.Size = new System.Drawing.Size(153, 44);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.guna2Panel2);
            this.panel.Controls.Add(this.guna2Panel1);
            this.panel.Controls.Add(this.lblTypeList);
            this.panel.Location = new System.Drawing.Point(16, 15);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1501, 930);
            this.panel.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblPhi);
            this.guna2Panel1.Controls.Add(this.cbPhi);
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.Controls.Add(this.cbStatus);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 62);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1463, 123);
            this.guna2Panel1.TabIndex = 1;
            // 
            // frmFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFunction";
            this.Size = new System.Drawing.Size(1533, 960);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTypeList;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblPhi;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhi;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnInsert;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
    }
}