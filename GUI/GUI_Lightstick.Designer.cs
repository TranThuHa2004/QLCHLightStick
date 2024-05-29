namespace GUI
{
    partial class GUI_Lightstick
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLightstick = new System.Windows.Forms.DataGridView();
            this.txtTimLT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btntimKiemLT = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemLT = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuaLT = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoaLT = new Guna.UI2.WinForms.Guna2Button();
            this.btnhienThiLT = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaLT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgiaTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmaNN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenLT = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLightstick)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 561);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLightstick
            // 
            this.dgvLightstick.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLightstick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLightstick.Location = new System.Drawing.Point(336, 63);
            this.dgvLightstick.Name = "dgvLightstick";
            this.dgvLightstick.RowHeadersWidth = 51;
            this.dgvLightstick.RowTemplate.Height = 24;
            this.dgvLightstick.Size = new System.Drawing.Size(681, 364);
            this.dgvLightstick.TabIndex = 2;
            this.dgvLightstick.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLightstick_CellClick);
            // 
            // txtTimLT
            // 
            this.txtTimLT.BackColor = System.Drawing.Color.Black;
            this.txtTimLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimLT.DefaultText = "";
            this.txtTimLT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimLT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimLT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimLT.ForeColor = System.Drawing.Color.Black;
            this.txtTimLT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimLT.Location = new System.Drawing.Point(496, 12);
            this.txtTimLT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimLT.Name = "txtTimLT";
            this.txtTimLT.PasswordChar = '\0';
            this.txtTimLT.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTimLT.PlaceholderText = "Nhập tên or mã Lightstick";
            this.txtTimLT.SelectedText = "";
            this.txtTimLT.Size = new System.Drawing.Size(280, 34);
            this.txtTimLT.TabIndex = 9;
            this.txtTimLT.TextChanged += new System.EventHandler(this.txtTimLT_TextChanged);
            // 
            // btntimKiemLT
            // 
            this.btntimKiemLT.AutoRoundedCorners = true;
            this.btntimKiemLT.BackColor = System.Drawing.Color.MistyRose;
            this.btntimKiemLT.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.btntimKiemLT.BorderRadius = 22;
            this.btntimKiemLT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemLT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimKiemLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimKiemLT.FillColor = System.Drawing.Color.RosyBrown;
            this.btntimKiemLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimKiemLT.ForeColor = System.Drawing.Color.White;
            this.btntimKiemLT.Image = global::GUI.Properties.Resources.search;
            this.btntimKiemLT.Location = new System.Drawing.Point(783, 12);
            this.btntimKiemLT.Name = "btntimKiemLT";
            this.btntimKiemLT.Size = new System.Drawing.Size(121, 46);
            this.btntimKiemLT.TabIndex = 10;
            this.btntimKiemLT.Text = "Tìm kiếm";
            // 
            // btnthemLT
            // 
            this.btnthemLT.AutoRoundedCorners = true;
            this.btnthemLT.BackColor = System.Drawing.Color.MistyRose;
            this.btnthemLT.BorderRadius = 22;
            this.btnthemLT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemLT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemLT.FillColor = System.Drawing.Color.RosyBrown;
            this.btnthemLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthemLT.ForeColor = System.Drawing.Color.White;
            this.btnthemLT.Image = global::GUI.Properties.Resources.plus;
            this.btnthemLT.Location = new System.Drawing.Point(6, 50);
            this.btnthemLT.Name = "btnthemLT";
            this.btnthemLT.Size = new System.Drawing.Size(121, 46);
            this.btnthemLT.TabIndex = 11;
            this.btnthemLT.Text = "Thêm";
            this.btnthemLT.Click += new System.EventHandler(this.btnthemLT_Click);
            // 
            // btnsuaLT
            // 
            this.btnsuaLT.AutoRoundedCorners = true;
            this.btnsuaLT.BackColor = System.Drawing.Color.MistyRose;
            this.btnsuaLT.BorderRadius = 22;
            this.btnsuaLT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaLT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuaLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuaLT.FillColor = System.Drawing.Color.RosyBrown;
            this.btnsuaLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsuaLT.ForeColor = System.Drawing.Color.White;
            this.btnsuaLT.Image = global::GUI.Properties.Resources.edit;
            this.btnsuaLT.Location = new System.Drawing.Point(145, 50);
            this.btnsuaLT.Name = "btnsuaLT";
            this.btnsuaLT.Size = new System.Drawing.Size(121, 46);
            this.btnsuaLT.TabIndex = 12;
            this.btnsuaLT.Text = "Sửa";
            this.btnsuaLT.Click += new System.EventHandler(this.btnsuaLT_Click);
            // 
            // btnxoaLT
            // 
            this.btnxoaLT.AutoRoundedCorners = true;
            this.btnxoaLT.BackColor = System.Drawing.Color.MistyRose;
            this.btnxoaLT.BorderRadius = 22;
            this.btnxoaLT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaLT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoaLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoaLT.FillColor = System.Drawing.Color.RosyBrown;
            this.btnxoaLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxoaLT.ForeColor = System.Drawing.Color.White;
            this.btnxoaLT.Image = global::GUI.Properties.Resources.trash;
            this.btnxoaLT.Location = new System.Drawing.Point(290, 50);
            this.btnxoaLT.Name = "btnxoaLT";
            this.btnxoaLT.Size = new System.Drawing.Size(121, 46);
            this.btnxoaLT.TabIndex = 13;
            this.btnxoaLT.Text = "Xóa";
            this.btnxoaLT.Click += new System.EventHandler(this.btnxoaLT_Click);
            // 
            // btnhienThiLT
            // 
            this.btnhienThiLT.AutoRoundedCorners = true;
            this.btnhienThiLT.BackColor = System.Drawing.Color.MistyRose;
            this.btnhienThiLT.BorderRadius = 22;
            this.btnhienThiLT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiLT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhienThiLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhienThiLT.FillColor = System.Drawing.Color.RosyBrown;
            this.btnhienThiLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhienThiLT.ForeColor = System.Drawing.Color.White;
            this.btnhienThiLT.Image = global::GUI.Properties.Resources.refresh;
            this.btnhienThiLT.Location = new System.Drawing.Point(417, 50);
            this.btnhienThiLT.Name = "btnhienThiLT";
            this.btnhienThiLT.Size = new System.Drawing.Size(121, 46);
            this.btnhienThiLT.TabIndex = 14;
            this.btnhienThiLT.Text = "Hiển Thị";
            this.btnhienThiLT.Click += new System.EventHandler(this.btnhienThiLT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Lightstick : ";
            // 
            // txtmaLT
            // 
            this.txtmaLT.BackColor = System.Drawing.Color.Black;
            this.txtmaLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaLT.DefaultText = "";
            this.txtmaLT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaLT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaLT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaLT.ForeColor = System.Drawing.Color.Black;
            this.txtmaLT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaLT.Location = new System.Drawing.Point(20, 63);
            this.txtmaLT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaLT.Name = "txtmaLT";
            this.txtmaLT.PasswordChar = '\0';
            this.txtmaLT.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtmaLT.PlaceholderText = "";
            this.txtmaLT.SelectedText = "";
            this.txtmaLT.Size = new System.Drawing.Size(282, 34);
            this.txtmaLT.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(20, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Giá tiền : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(16, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số lượng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mã NN : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(16, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tên Lightstick : ";
            // 
            // txtgiaTien
            // 
            this.txtgiaTien.BackColor = System.Drawing.Color.Black;
            this.txtgiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiaTien.DefaultText = "";
            this.txtgiaTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgiaTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgiaTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiaTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgiaTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiaTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtgiaTien.ForeColor = System.Drawing.Color.Black;
            this.txtgiaTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgiaTien.Location = new System.Drawing.Point(25, 354);
            this.txtgiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgiaTien.Name = "txtgiaTien";
            this.txtgiaTien.PasswordChar = '\0';
            this.txtgiaTien.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtgiaTien.PlaceholderText = "";
            this.txtgiaTien.SelectedText = "";
            this.txtgiaTien.Size = new System.Drawing.Size(277, 34);
            this.txtgiaTien.TabIndex = 33;
            // 
            // txtmaNN
            // 
            this.txtmaNN.BackColor = System.Drawing.Color.Black;
            this.txtmaNN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaNN.DefaultText = "";
            this.txtmaNN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaNN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaNN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaNN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaNN.ForeColor = System.Drawing.Color.Black;
            this.txtmaNN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaNN.Location = new System.Drawing.Point(20, 203);
            this.txtmaNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaNN.Name = "txtmaNN";
            this.txtmaNN.PasswordChar = '\0';
            this.txtmaNN.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtmaNN.PlaceholderText = "";
            this.txtmaNN.SelectedText = "";
            this.txtmaNN.Size = new System.Drawing.Size(282, 34);
            this.txtmaNN.TabIndex = 35;
            // 
            // txttenLT
            // 
            this.txttenLT.BackColor = System.Drawing.Color.Black;
            this.txttenLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenLT.DefaultText = "";
            this.txttenLT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenLT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenLT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttenLT.ForeColor = System.Drawing.Color.Black;
            this.txttenLT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenLT.Location = new System.Drawing.Point(20, 139);
            this.txttenLT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenLT.Name = "txttenLT";
            this.txttenLT.PasswordChar = '\0';
            this.txttenLT.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txttenLT.PlaceholderText = "";
            this.txttenLT.SelectedText = "";
            this.txttenLT.Size = new System.Drawing.Size(282, 34);
            this.txttenLT.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.btnthemLT);
            this.groupBox1.Controls.Add(this.btnsuaLT);
            this.groupBox1.Controls.Add(this.btnxoaLT);
            this.groupBox1.Controls.Add(this.btnhienThiLT);
            this.groupBox1.Location = new System.Drawing.Point(336, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 121);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.txtsoLuong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmaLT);
            this.groupBox2.Controls.Add(this.txtgiaTien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmaNN);
            this.groupBox2.Controls.Add(this.txttenLT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 561);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Lightstick";
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtsoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsoLuong.Location = new System.Drawing.Point(25, 282);
            this.txtsoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(277, 34);
            this.txtsoLuong.TabIndex = 37;
            // 
            // GUI_Lightstick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntimKiemLT);
            this.Controls.Add(this.txtTimLT);
            this.Controls.Add(this.dgvLightstick);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_Lightstick";
            this.Text = "Lightstick";
            this.Load += new System.EventHandler(this.GUI_Lightstick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLightstick)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLightstick;
        private Guna.UI2.WinForms.Guna2TextBox txtTimLT;
        private Guna.UI2.WinForms.Guna2Button btntimKiemLT;
        private Guna.UI2.WinForms.Guna2Button btnthemLT;
        private Guna.UI2.WinForms.Guna2Button btnsuaLT;
        private Guna.UI2.WinForms.Guna2Button btnxoaLT;
        private Guna.UI2.WinForms.Guna2Button btnhienThiLT;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtmaLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtgiaTien;
        private Guna.UI2.WinForms.Guna2TextBox txtmaNN;
        private Guna.UI2.WinForms.Guna2TextBox txttenLT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtsoLuong;
    }
}