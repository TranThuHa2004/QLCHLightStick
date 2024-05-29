namespace GUI
{
    partial class GUI_DonHangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDHN = new System.Windows.Forms.DataGridView();
            this.dtpngayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbomaNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongThanhToan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmaDHN = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnhienThiDHN = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoaDHN = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuaDHN = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemDHN = new Guna.UI2.WinForms.Guna2Button();
            this.btntimKiemDHN = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimDHN = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã ĐHN : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(23, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngày nhập : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(22, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mã NV : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(23, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Mã NCC : ";
            // 
            // dgvDHN
            // 
            this.dgvDHN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDHN.Location = new System.Drawing.Point(342, 81);
            this.dgvDHN.Name = "dgvDHN";
            this.dgvDHN.RowHeadersWidth = 51;
            this.dgvDHN.RowTemplate.Height = 24;
            this.dgvDHN.Size = new System.Drawing.Size(675, 358);
            this.dgvDHN.TabIndex = 62;
            this.dgvDHN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDHN_CellClick);
            // 
            // dtpngayNhap
            // 
            this.dtpngayNhap.Checked = true;
            this.dtpngayNhap.FillColor = System.Drawing.Color.White;
            this.dtpngayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpngayNhap.Location = new System.Drawing.Point(27, 357);
            this.dtpngayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpngayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpngayNhap.Name = "dtpngayNhap";
            this.dtpngayNhap.Size = new System.Drawing.Size(205, 36);
            this.dtpngayNhap.TabIndex = 67;
            this.dtpngayNhap.Value = new System.DateTime(2024, 5, 15, 10, 40, 59, 993);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.cbomaNV);
            this.groupBox1.Controls.Add(this.cbomaNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpngayNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTongThanhToan);
            this.groupBox1.Controls.Add(this.txtmaDHN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 561);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Đơn hàng nhập";
            // 
            // cbomaNV
            // 
            this.cbomaNV.BackColor = System.Drawing.Color.Transparent;
            this.cbomaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbomaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbomaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbomaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbomaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbomaNV.ItemHeight = 30;
            this.cbomaNV.Location = new System.Drawing.Point(27, 272);
            this.cbomaNV.Name = "cbomaNV";
            this.cbomaNV.Size = new System.Drawing.Size(200, 36);
            this.cbomaNV.TabIndex = 71;
            // 
            // cbomaNCC
            // 
            this.cbomaNCC.BackColor = System.Drawing.Color.Transparent;
            this.cbomaNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbomaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbomaNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbomaNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbomaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbomaNCC.ItemHeight = 30;
            this.cbomaNCC.Location = new System.Drawing.Point(27, 173);
            this.cbomaNCC.Name = "cbomaNCC";
            this.cbomaNCC.Size = new System.Drawing.Size(200, 36);
            this.cbomaNCC.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(22, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tổng thanh toán :";
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.BackColor = System.Drawing.Color.Black;
            this.txtTongThanhToan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongThanhToan.DefaultText = "0";
            this.txtTongThanhToan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongThanhToan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongThanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongThanhToan.ForeColor = System.Drawing.Color.Black;
            this.txtTongThanhToan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongThanhToan.Location = new System.Drawing.Point(26, 451);
            this.txtTongThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.PasswordChar = '\0';
            this.txtTongThanhToan.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTongThanhToan.PlaceholderText = "";
            this.txtTongThanhToan.SelectedText = "";
            this.txtTongThanhToan.Size = new System.Drawing.Size(201, 34);
            this.txtTongThanhToan.TabIndex = 52;
            // 
            // txtmaDHN
            // 
            this.txtmaDHN.BackColor = System.Drawing.Color.Black;
            this.txtmaDHN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaDHN.DefaultText = "";
            this.txtmaDHN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaDHN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaDHN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaDHN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaDHN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaDHN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaDHN.ForeColor = System.Drawing.Color.Black;
            this.txtmaDHN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaDHN.Location = new System.Drawing.Point(26, 81);
            this.txtmaDHN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaDHN.Name = "txtmaDHN";
            this.txtmaDHN.PasswordChar = '\0';
            this.txtmaDHN.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtmaDHN.PlaceholderText = "";
            this.txtmaDHN.SelectedText = "";
            this.txtmaDHN.Size = new System.Drawing.Size(201, 34);
            this.txtmaDHN.TabIndex = 52;
            // 
            // btnhienThiDHN
            // 
            this.btnhienThiDHN.AutoRoundedCorners = true;
            this.btnhienThiDHN.BackColor = System.Drawing.Color.MistyRose;
            this.btnhienThiDHN.BorderRadius = 22;
            this.btnhienThiDHN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiDHN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiDHN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhienThiDHN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhienThiDHN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnhienThiDHN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhienThiDHN.ForeColor = System.Drawing.Color.White;
            this.btnhienThiDHN.Image = global::GUI.Properties.Resources.refresh;
            this.btnhienThiDHN.Location = new System.Drawing.Point(532, 38);
            this.btnhienThiDHN.Name = "btnhienThiDHN";
            this.btnhienThiDHN.Size = new System.Drawing.Size(121, 46);
            this.btnhienThiDHN.TabIndex = 66;
            this.btnhienThiDHN.Text = "Hiển Thị";
            this.btnhienThiDHN.Click += new System.EventHandler(this.btnhienThiDHN_Click);
            // 
            // btnxoaDHN
            // 
            this.btnxoaDHN.AutoRoundedCorners = true;
            this.btnxoaDHN.BackColor = System.Drawing.Color.MistyRose;
            this.btnxoaDHN.BorderRadius = 22;
            this.btnxoaDHN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaDHN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaDHN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoaDHN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoaDHN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnxoaDHN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxoaDHN.ForeColor = System.Drawing.Color.White;
            this.btnxoaDHN.Image = global::GUI.Properties.Resources.trash;
            this.btnxoaDHN.Location = new System.Drawing.Point(374, 38);
            this.btnxoaDHN.Name = "btnxoaDHN";
            this.btnxoaDHN.Size = new System.Drawing.Size(121, 46);
            this.btnxoaDHN.TabIndex = 65;
            this.btnxoaDHN.Text = "Xóa";
            this.btnxoaDHN.Click += new System.EventHandler(this.btnxoaDHN_Click);
            // 
            // btnsuaDHN
            // 
            this.btnsuaDHN.AutoRoundedCorners = true;
            this.btnsuaDHN.BackColor = System.Drawing.Color.MistyRose;
            this.btnsuaDHN.BorderRadius = 22;
            this.btnsuaDHN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaDHN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaDHN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuaDHN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuaDHN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnsuaDHN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsuaDHN.ForeColor = System.Drawing.Color.White;
            this.btnsuaDHN.Image = global::GUI.Properties.Resources.edit;
            this.btnsuaDHN.Location = new System.Drawing.Point(222, 38);
            this.btnsuaDHN.Name = "btnsuaDHN";
            this.btnsuaDHN.Size = new System.Drawing.Size(121, 46);
            this.btnsuaDHN.TabIndex = 64;
            this.btnsuaDHN.Text = "Sửa";
            this.btnsuaDHN.Click += new System.EventHandler(this.btnsuaDHN_Click);
            // 
            // btnthemDHN
            // 
            this.btnthemDHN.AutoRoundedCorners = true;
            this.btnthemDHN.BackColor = System.Drawing.Color.MistyRose;
            this.btnthemDHN.BorderRadius = 22;
            this.btnthemDHN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemDHN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemDHN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemDHN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemDHN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnthemDHN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthemDHN.ForeColor = System.Drawing.Color.White;
            this.btnthemDHN.Image = global::GUI.Properties.Resources.plus;
            this.btnthemDHN.Location = new System.Drawing.Point(85, 38);
            this.btnthemDHN.Name = "btnthemDHN";
            this.btnthemDHN.Size = new System.Drawing.Size(121, 46);
            this.btnthemDHN.TabIndex = 63;
            this.btnthemDHN.Text = "Thêm";
            this.btnthemDHN.Click += new System.EventHandler(this.btnthemDHN_Click);
            // 
            // btntimKiemDHN
            // 
            this.btntimKiemDHN.AutoRoundedCorners = true;
            this.btntimKiemDHN.BackColor = System.Drawing.Color.MistyRose;
            this.btntimKiemDHN.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.btntimKiemDHN.BorderRadius = 22;
            this.btntimKiemDHN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemDHN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemDHN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimKiemDHN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimKiemDHN.FillColor = System.Drawing.Color.RosyBrown;
            this.btntimKiemDHN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimKiemDHN.ForeColor = System.Drawing.Color.White;
            this.btntimKiemDHN.Image = global::GUI.Properties.Resources.search;
            this.btntimKiemDHN.Location = new System.Drawing.Point(803, 13);
            this.btntimKiemDHN.Name = "btntimKiemDHN";
            this.btntimKiemDHN.Size = new System.Drawing.Size(121, 46);
            this.btntimKiemDHN.TabIndex = 61;
            this.btntimKiemDHN.Text = "Tìm kiếm";
            this.btntimKiemDHN.Click += new System.EventHandler(this.btntimKiemDHN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 561);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnsuaDHN);
            this.groupBox2.Controls.Add(this.btnthemDHN);
            this.groupBox2.Controls.Add(this.btnhienThiDHN);
            this.groupBox2.Controls.Add(this.btnxoaDHN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(336, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 110);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtTimDHN
            // 
            this.txtTimDHN.Animated = true;
            this.txtTimDHN.AutoRoundedCorners = true;
            this.txtTimDHN.BorderRadius = 17;
            this.txtTimDHN.Checked = true;
            this.txtTimDHN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimDHN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimDHN.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTimDHN.Location = new System.Drawing.Point(529, 23);
            this.txtTimDHN.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTimDHN.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTimDHN.Name = "txtTimDHN";
            this.txtTimDHN.Size = new System.Drawing.Size(249, 36);
            this.txtTimDHN.TabIndex = 78;
            this.txtTimDHN.Value = new System.DateTime(2024, 5, 22, 20, 34, 59, 48);
            // 
            // GUI_DonHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.txtTimDHN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDHN);
            this.Controls.Add(this.btntimKiemDHN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_DonHangNhap";
            this.Text = "Đơn Hàng Nhập";
            this.Load += new System.EventHandler(this.GUI_DonHangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btntimKiemDHN;
        private System.Windows.Forms.DataGridView dgvDHN;
        private Guna.UI2.WinForms.Guna2Button btnthemDHN;
        private Guna.UI2.WinForms.Guna2Button btnsuaDHN;
        private Guna.UI2.WinForms.Guna2Button btnxoaDHN;
        private Guna.UI2.WinForms.Guna2Button btnhienThiDHN;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpngayNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtmaDHN;
        private Guna.UI2.WinForms.Guna2ComboBox cbomaNCC;
        private Guna.UI2.WinForms.Guna2ComboBox cbomaNV;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTongThanhToan;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTimDHN;
    }
}