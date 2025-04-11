namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnNhacNho = new FontAwesome.Sharp.IconButton();
            this.btnInfoTro = new FontAwesome.Sharp.IconButton();
            this.btnKhac = new FontAwesome.Sharp.IconButton();
            this.btnThongke = new FontAwesome.Sharp.IconButton();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.btnDienNuoc = new FontAwesome.Sharp.IconButton();
            this.btnVanTay = new FontAwesome.Sharp.IconButton();
            this.btnKhach = new FontAwesome.Sharp.IconButton();
            this.btnHopDong = new FontAwesome.Sharp.IconButton();
            this.btnPhong = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.panelSidebar.Controls.Add(this.btnNhacNho);
            this.panelSidebar.Controls.Add(this.btnInfoTro);
            this.panelSidebar.Controls.Add(this.btnKhac);
            this.panelSidebar.Controls.Add(this.btnThongke);
            this.panelSidebar.Controls.Add(this.btnThanhToan);
            this.panelSidebar.Controls.Add(this.btnDienNuoc);
            this.panelSidebar.Controls.Add(this.btnVanTay);
            this.panelSidebar.Controls.Add(this.btnKhach);
            this.panelSidebar.Controls.Add(this.btnHopDong);
            this.panelSidebar.Controls.Add(this.btnPhong);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(13, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(320, 1046);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnNhacNho
            // 
            this.btnNhacNho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnNhacNho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhacNho.FlatAppearance.BorderSize = 0;
            this.btnNhacNho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhacNho.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhacNho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnNhacNho.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNhacNho.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnNhacNho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhacNho.IconSize = 30;
            this.btnNhacNho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhacNho.Location = new System.Drawing.Point(0, 743);
            this.btnNhacNho.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhacNho.Name = "btnNhacNho";
            this.btnNhacNho.Size = new System.Drawing.Size(320, 62);
            this.btnNhacNho.TabIndex = 14;
            this.btnNhacNho.Text = "Nhắc nhở - thông báo";
            this.btnNhacNho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhacNho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhacNho.UseVisualStyleBackColor = false;
            this.btnNhacNho.Click += new System.EventHandler(this.btnNhacNho_Click);
            // 
            // btnInfoTro
            // 
            this.btnInfoTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnInfoTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoTro.FlatAppearance.BorderSize = 0;
            this.btnInfoTro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoTro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnInfoTro.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfoTro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnInfoTro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfoTro.IconSize = 30;
            this.btnInfoTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoTro.Location = new System.Drawing.Point(0, 681);
            this.btnInfoTro.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoTro.Name = "btnInfoTro";
            this.btnInfoTro.Size = new System.Drawing.Size(320, 62);
            this.btnInfoTro.TabIndex = 13;
            this.btnInfoTro.Text = "Thông tin nhà trọ";
            this.btnInfoTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfoTro.UseVisualStyleBackColor = false;
            this.btnInfoTro.Click += new System.EventHandler(this.btnInfoTro_Click);
            // 
            // btnKhac
            // 
            this.btnKhac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnKhac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhac.FlatAppearance.BorderSize = 0;
            this.btnKhac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnKhac.IconChar = FontAwesome.Sharp.IconChar.FeatherPointed;
            this.btnKhac.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnKhac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhac.IconSize = 30;
            this.btnKhac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhac.Location = new System.Drawing.Point(0, 619);
            this.btnKhac.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(320, 62);
            this.btnKhac.TabIndex = 12;
            this.btnKhac.Text = "Các dịch vụ khác";
            this.btnKhac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhac.UseVisualStyleBackColor = false;
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnThongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnThongke.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnThongke.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnThongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongke.IconSize = 30;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(0, 557);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(320, 62);
            this.btnThongke.TabIndex = 11;
            this.btnThongke.Text = "Thống kê - báo cáo";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnThanhToan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 30;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 495);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(320, 62);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán - hóa đơn";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDienNuoc
            // 
            this.btnDienNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnDienNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDienNuoc.FlatAppearance.BorderSize = 0;
            this.btnDienNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDienNuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDienNuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnDienNuoc.IconChar = FontAwesome.Sharp.IconChar.HouseFloodWater;
            this.btnDienNuoc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnDienNuoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDienNuoc.IconSize = 30;
            this.btnDienNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDienNuoc.Location = new System.Drawing.Point(0, 433);
            this.btnDienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDienNuoc.Name = "btnDienNuoc";
            this.btnDienNuoc.Size = new System.Drawing.Size(320, 62);
            this.btnDienNuoc.TabIndex = 7;
            this.btnDienNuoc.Text = "Quản lý điện nước";
            this.btnDienNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDienNuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDienNuoc.UseVisualStyleBackColor = false;
            this.btnDienNuoc.Click += new System.EventHandler(this.btnDienNuoc_Click);
            // 
            // btnVanTay
            // 
            this.btnVanTay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnVanTay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVanTay.FlatAppearance.BorderSize = 0;
            this.btnVanTay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVanTay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVanTay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnVanTay.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnVanTay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnVanTay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVanTay.IconSize = 30;
            this.btnVanTay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVanTay.Location = new System.Drawing.Point(0, 371);
            this.btnVanTay.Margin = new System.Windows.Forms.Padding(4);
            this.btnVanTay.Name = "btnVanTay";
            this.btnVanTay.Size = new System.Drawing.Size(320, 62);
            this.btnVanTay.TabIndex = 5;
            this.btnVanTay.Text = "Quản lý đăng ký vân tay";
            this.btnVanTay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVanTay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVanTay.UseVisualStyleBackColor = false;
            this.btnVanTay.Click += new System.EventHandler(this.btnVanTay_Click);
            // 
            // btnKhach
            // 
            this.btnKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhach.FlatAppearance.BorderSize = 0;
            this.btnKhach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnKhach.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnKhach.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnKhach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhach.IconSize = 30;
            this.btnKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhach.Location = new System.Drawing.Point(0, 309);
            this.btnKhach.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Size = new System.Drawing.Size(320, 62);
            this.btnKhach.TabIndex = 4;
            this.btnKhach.Text = "Quản lý khách thuê";
            this.btnKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhach.UseVisualStyleBackColor = false;
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnHopDong.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnHopDong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHopDong.IconSize = 30;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.Location = new System.Drawing.Point(0, 247);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(320, 62);
            this.btnHopDong.TabIndex = 3;
            this.btnHopDong.Text = "Quản lý hợp đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnPhong.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnPhong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhong.IconSize = 30;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(0, 185);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(320, 62);
            this.btnPhong.TabIndex = 1;
            this.btnPhong.Text = "Quản lý phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(320, 185);
            this.panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(320, 185);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(218)))));
            this.panelTopbar.Controls.Add(this.btnLogout);
            this.panelTopbar.Controls.Add(this.btnUser);
            this.panelTopbar.Controls.Add(this.labelCurrent);
            this.panelTopbar.Controls.Add(this.iconCurrent);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(333, 0);
            this.panelTopbar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(1534, 86);
            this.panelTopbar.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1359, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 62);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            // 
            // btnUser
            // 
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnUser.IconColor = System.Drawing.Color.Black;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 50;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUser.Location = new System.Drawing.Point(1268, 12);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(67, 62);
            this.btnUser.TabIndex = 2;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelCurrent.Location = new System.Drawing.Point(84, 26);
            this.labelCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(142, 37);
            this.labelCurrent.TabIndex = 1;
            this.labelCurrent.Text = "Trang chủ";
            // 
            // iconCurrent
            // 
            this.iconCurrent.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconCurrent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.iconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrent.IconSize = 39;
            this.iconCurrent.Location = new System.Drawing.Point(33, 23);
            this.iconCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(43, 39);
            this.iconCurrent.TabIndex = 0;
            this.iconCurrent.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(225)))));
            this.panelDesktop.Controls.Add(this.guna2Panel1);
            this.panelDesktop.Controls.Add(this.panelContent);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(333, 86);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1534, 960);
            this.panelDesktop.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(247, 46);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1040, 86);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(212, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm Quản lý Phòng trọ";
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(76, 160);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1381, 738);
            this.panelContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1046);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTopbar);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTopbar.ResumeLayout(false);
            this.panelTopbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPhong;
        private FontAwesome.Sharp.IconButton btnVanTay;
        private FontAwesome.Sharp.IconButton btnKhach;
        private FontAwesome.Sharp.IconButton btnHopDong;
        private FontAwesome.Sharp.IconButton btnInfoTro;
        private FontAwesome.Sharp.IconButton btnKhac;
        private FontAwesome.Sharp.IconButton btnThongke;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private FontAwesome.Sharp.IconButton btnDienNuoc;
        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelCurrent;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private FontAwesome.Sharp.IconButton btnUser;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton btnNhacNho;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}