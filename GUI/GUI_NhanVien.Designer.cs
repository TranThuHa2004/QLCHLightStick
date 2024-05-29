namespace GUI
{
    partial class GUI_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_NhanVien));
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnhienThiNV = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimNhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsdtNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsuaNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoaNV = new Guna.UI2.WinForms.Guna2Button();
            this.btntimKiemNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemNV = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo = new System.Windows.Forms.GroupBox();
            this.txtgioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Location = new System.Drawing.Point(348, 75);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(669, 386);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // btnhienThiNV
            // 
            this.btnhienThiNV.AutoRoundedCorners = true;
            this.btnhienThiNV.BackColor = System.Drawing.Color.MistyRose;
            this.btnhienThiNV.BorderRadius = 22;
            this.btnhienThiNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhienThiNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhienThiNV.FillColor = System.Drawing.Color.RosyBrown;
            this.btnhienThiNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhienThiNV.ForeColor = System.Drawing.Color.White;
            this.btnhienThiNV.Image = global::GUI.Properties.Resources.refresh;
            this.btnhienThiNV.Location = new System.Drawing.Point(482, 36);
            this.btnhienThiNV.Name = "btnhienThiNV";
            this.btnhienThiNV.Size = new System.Drawing.Size(150, 46);
            this.btnhienThiNV.TabIndex = 3;
            this.btnhienThiNV.Text = "Hiển Thị";
            this.btnhienThiNV.Click += new System.EventHandler(this.btnhienThiNV_Click);
            // 
            // txtTimNhanvien
            // 
            this.txtTimNhanvien.BackColor = System.Drawing.Color.Black;
            this.txtTimNhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimNhanvien.DefaultText = "";
            this.txtTimNhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimNhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimNhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNhanvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimNhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtTimNhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNhanvien.Location = new System.Drawing.Point(447, 24);
            this.txtTimNhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimNhanvien.Name = "txtTimNhanvien";
            this.txtTimNhanvien.PasswordChar = '\0';
            this.txtTimNhanvien.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTimNhanvien.PlaceholderText = "Nhập tên or mã nhân viên";
            this.txtTimNhanvien.SelectedText = "";
            this.txtTimNhanvien.Size = new System.Drawing.Size(280, 34);
            this.txtTimNhanvien.TabIndex = 0;
            this.txtTimNhanvien.TextChanged += new System.EventHandler(this.txtTimNhanvien_TextChanged);
            // 
            // txttenNV
            // 
            this.txttenNV.BackColor = System.Drawing.Color.Black;
            this.txttenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenNV.DefaultText = "";
            this.txttenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttenNV.ForeColor = System.Drawing.Color.Black;
            this.txttenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenNV.Location = new System.Drawing.Point(10, 129);
            this.txttenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.PasswordChar = '\0';
            this.txttenNV.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txttenNV.PlaceholderText = "";
            this.txttenNV.SelectedText = "";
            this.txttenNV.Size = new System.Drawing.Size(320, 34);
            this.txttenNV.TabIndex = 0;
            // 
            // txtdiaChi
            // 
            this.txtdiaChi.BackColor = System.Drawing.Color.Black;
            this.txtdiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiaChi.DefaultText = "";
            this.txtdiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtdiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtdiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiaChi.Location = new System.Drawing.Point(10, 289);
            this.txtdiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiaChi.Name = "txtdiaChi";
            this.txtdiaChi.PasswordChar = '\0';
            this.txtdiaChi.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtdiaChi.PlaceholderText = "";
            this.txtdiaChi.SelectedText = "";
            this.txtdiaChi.Size = new System.Drawing.Size(320, 34);
            this.txtdiaChi.TabIndex = 5;
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.Black;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.DefaultText = "";
            this.txtLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLuong.ForeColor = System.Drawing.Color.Black;
            this.txtLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuong.Location = new System.Drawing.Point(10, 446);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLuong.PlaceholderText = "";
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(320, 34);
            this.txtLuong.TabIndex = 3;
            // 
            // txtmaNV
            // 
            this.txtmaNV.BackColor = System.Drawing.Color.Black;
            this.txtmaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaNV.DefaultText = "";
            this.txtmaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaNV.ForeColor = System.Drawing.Color.Black;
            this.txtmaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaNV.Location = new System.Drawing.Point(7, 53);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.PasswordChar = '\0';
            this.txtmaNV.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtmaNV.PlaceholderText = "";
            this.txtmaNV.SelectedText = "";
            this.txtmaNV.Size = new System.Drawing.Size(320, 34);
            this.txtmaNV.TabIndex = 2;
            // 
            // txtsdtNV
            // 
            this.txtsdtNV.BackColor = System.Drawing.Color.Black;
            this.txtsdtNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdtNV.DefaultText = "";
            this.txtsdtNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsdtNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsdtNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdtNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdtNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdtNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsdtNV.ForeColor = System.Drawing.Color.Black;
            this.txtsdtNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdtNV.Location = new System.Drawing.Point(10, 367);
            this.txtsdtNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsdtNV.Name = "txtsdtNV";
            this.txtsdtNV.PasswordChar = '\0';
            this.txtsdtNV.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtsdtNV.PlaceholderText = "";
            this.txtsdtNV.SelectedText = "";
            this.txtsdtNV.Size = new System.Drawing.Size(320, 34);
            this.txtsdtNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên nhân viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(9, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Địa chỉ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(8, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Giới tính : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(11, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lương : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mã nhân viên : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(11, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sđt nhân viên : ";
            // 
            // btnsuaNV
            // 
            this.btnsuaNV.AutoRoundedCorners = true;
            this.btnsuaNV.BackColor = System.Drawing.Color.MistyRose;
            this.btnsuaNV.BorderRadius = 22;
            this.btnsuaNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuaNV.FillColor = System.Drawing.Color.RosyBrown;
            this.btnsuaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsuaNV.ForeColor = System.Drawing.Color.White;
            this.btnsuaNV.Image = global::GUI.Properties.Resources.edit;
            this.btnsuaNV.Location = new System.Drawing.Point(160, 36);
            this.btnsuaNV.Name = "btnsuaNV";
            this.btnsuaNV.Size = new System.Drawing.Size(121, 46);
            this.btnsuaNV.TabIndex = 1;
            this.btnsuaNV.Text = "Sửa";
            this.btnsuaNV.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoaNV
            // 
            this.btnxoaNV.AutoRoundedCorners = true;
            this.btnxoaNV.BackColor = System.Drawing.Color.MistyRose;
            this.btnxoaNV.BorderRadius = 22;
            this.btnxoaNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoaNV.FillColor = System.Drawing.Color.RosyBrown;
            this.btnxoaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxoaNV.ForeColor = System.Drawing.Color.White;
            this.btnxoaNV.Image = global::GUI.Properties.Resources.trash;
            this.btnxoaNV.Location = new System.Drawing.Point(306, 36);
            this.btnxoaNV.Name = "btnxoaNV";
            this.btnxoaNV.Size = new System.Drawing.Size(121, 46);
            this.btnxoaNV.TabIndex = 2;
            this.btnxoaNV.Text = "Xóa";
            this.btnxoaNV.Click += new System.EventHandler(this.btnxoaNV_Click);
            // 
            // btntimKiemNV
            // 
            this.btntimKiemNV.AutoRoundedCorners = true;
            this.btntimKiemNV.BackColor = System.Drawing.Color.MistyRose;
            this.btntimKiemNV.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.btntimKiemNV.BorderRadius = 22;
            this.btntimKiemNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimKiemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimKiemNV.FillColor = System.Drawing.Color.RosyBrown;
            this.btntimKiemNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimKiemNV.ForeColor = System.Drawing.Color.White;
            this.btntimKiemNV.Image = global::GUI.Properties.Resources.search;
            this.btntimKiemNV.Location = new System.Drawing.Point(789, 12);
            this.btntimKiemNV.Name = "btntimKiemNV";
            this.btntimKiemNV.Size = new System.Drawing.Size(121, 46);
            this.btntimKiemNV.TabIndex = 1;
            this.btntimKiemNV.Text = "Tìm kiếm";
            // 
            // btnthemNV
            // 
            this.btnthemNV.AutoRoundedCorners = true;
            this.btnthemNV.BackColor = System.Drawing.Color.MistyRose;
            this.btnthemNV.BorderRadius = 22;
            this.btnthemNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemNV.FillColor = System.Drawing.Color.RosyBrown;
            this.btnthemNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthemNV.ForeColor = System.Drawing.Color.White;
            this.btnthemNV.Image = global::GUI.Properties.Resources.plus;
            this.btnthemNV.Location = new System.Drawing.Point(13, 36);
            this.btnthemNV.Name = "btnthemNV";
            this.btnthemNV.Size = new System.Drawing.Size(121, 46);
            this.btnthemNV.TabIndex = 0;
            this.btnthemNV.Text = "Thêm";
            this.btnthemNV.Click += new System.EventHandler(this.btnthemNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 561);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.btnthemNV);
            this.groupBox1.Controls.Add(this.btnsuaNV);
            this.groupBox1.Controls.Add(this.btnxoaNV);
            this.groupBox1.Controls.Add(this.btnhienThiNV);
            this.groupBox1.Location = new System.Drawing.Point(348, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 94);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // cbo
            // 
            this.cbo.BackColor = System.Drawing.Color.MistyRose;
            this.cbo.Controls.Add(this.txtgioiTinh);
            this.cbo.Controls.Add(this.label1);
            this.cbo.Controls.Add(this.txttenNV);
            this.cbo.Controls.Add(this.txtdiaChi);
            this.cbo.Controls.Add(this.txtLuong);
            this.cbo.Controls.Add(this.label2);
            this.cbo.Controls.Add(this.label6);
            this.cbo.Controls.Add(this.label3);
            this.cbo.Controls.Add(this.label4);
            this.cbo.Controls.Add(this.label5);
            this.cbo.Controls.Add(this.txtsdtNV);
            this.cbo.Controls.Add(this.txtmaNV);
            this.cbo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbo.Location = new System.Drawing.Point(0, 0);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(342, 561);
            this.cbo.TabIndex = 34;
            this.cbo.TabStop = false;
            this.cbo.Text = "Thông tin Nhân viên";
            // 
            // txtgioiTinh
            // 
            this.txtgioiTinh.FormattingEnabled = true;
            this.txtgioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtgioiTinh.Location = new System.Drawing.Point(10, 210);
            this.txtgioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgioiTinh.Name = "txtgioiTinh";
            this.txtgioiTinh.Size = new System.Drawing.Size(315, 24);
            this.txtgioiTinh.TabIndex = 4;
            // 
            // GUI_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimNhanvien);
            this.Controls.Add(this.btntimKiemNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_NhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.GUI_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.cbo.ResumeLayout(false);
            this.cbo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnthemNV;
        private Guna.UI2.WinForms.Guna2Button btntimKiemNV;
        private Guna.UI2.WinForms.Guna2Button btnhienThiNV;
        private Guna.UI2.WinForms.Guna2Button btnxoaNV;
        private Guna.UI2.WinForms.Guna2Button btnsuaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimNhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txttenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtdiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtmaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtsdtNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cbo;
        private System.Windows.Forms.ComboBox txtgioiTinh;
    }
}