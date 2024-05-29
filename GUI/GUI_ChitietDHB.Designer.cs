namespace GUI
{
    partial class GUI_ChitietDHB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgiaTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txttenLT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtmaDHB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtmaLT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsuaCTDHB = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemCTDHB = new Guna.UI2.WinForms.Guna2Button();
            this.btnhienThiCTDHB = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoaCTDHB = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCTDHB = new System.Windows.Forms.DataGridView();
            this.btntimKiemCTDHB = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimCTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDHB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtgiaTien);
            this.groupBox1.Controls.Add(this.txtsoLuong);
            this.groupBox1.Controls.Add(this.txttenLT);
            this.groupBox1.Controls.Add(this.txtmaDHB);
            this.groupBox1.Controls.Add(this.txtmaLT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaCTB);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 561);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chi tiết Đơn hàng bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(22, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Giá tiền : ";
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
            this.txtgiaTien.Location = new System.Drawing.Point(27, 354);
            this.txtgiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgiaTien.Name = "txtgiaTien";
            this.txtgiaTien.PasswordChar = '\0';
            this.txtgiaTien.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtgiaTien.PlaceholderText = "";
            this.txtgiaTien.SelectedText = "";
            this.txtgiaTien.Size = new System.Drawing.Size(201, 34);
            this.txtgiaTien.TabIndex = 67;
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtsoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsoLuong.Location = new System.Drawing.Point(25, 432);
            this.txtsoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(201, 37);
            this.txtsoLuong.TabIndex = 65;
            this.txtsoLuong.ValueChanged += new System.EventHandler(this.txtsoLuong_ValueChanged);
            // 
            // txttenLT
            // 
            this.txttenLT.BackColor = System.Drawing.Color.Transparent;
            this.txttenLT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txttenLT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttenLT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenLT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttenLT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txttenLT.ItemHeight = 30;
            this.txttenLT.Location = new System.Drawing.Point(25, 285);
            this.txttenLT.Name = "txttenLT";
            this.txttenLT.Size = new System.Drawing.Size(201, 36);
            this.txttenLT.TabIndex = 64;
            // 
            // txtmaDHB
            // 
            this.txtmaDHB.BackColor = System.Drawing.Color.Transparent;
            this.txtmaDHB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtmaDHB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmaDHB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaDHB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaDHB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaDHB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtmaDHB.ItemHeight = 30;
            this.txtmaDHB.Location = new System.Drawing.Point(26, 132);
            this.txtmaDHB.Name = "txtmaDHB";
            this.txtmaDHB.Size = new System.Drawing.Size(201, 36);
            this.txtmaDHB.TabIndex = 64;
            // 
            // txtmaLT
            // 
            this.txtmaLT.BackColor = System.Drawing.Color.Transparent;
            this.txtmaLT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtmaLT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmaLT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaLT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaLT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaLT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtmaLT.ItemHeight = 30;
            this.txtmaLT.Location = new System.Drawing.Point(25, 209);
            this.txtmaLT.Name = "txtmaLT";
            this.txtmaLT.Size = new System.Drawing.Size(201, 36);
            this.txtmaLT.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(15, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tên LT : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Mã LT : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã ĐHB : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(19, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Mã chi tiết bán :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(22, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tổng tiền :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(20, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Số lượng : ";
            // 
            // txtMaCTB
            // 
            this.txtMaCTB.BackColor = System.Drawing.Color.Black;
            this.txtMaCTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCTB.DefaultText = "";
            this.txtMaCTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCTB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaCTB.ForeColor = System.Drawing.Color.Black;
            this.txtMaCTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCTB.Location = new System.Drawing.Point(24, 54);
            this.txtMaCTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCTB.Name = "txtMaCTB";
            this.txtMaCTB.PasswordChar = '\0';
            this.txtMaCTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMaCTB.PlaceholderText = "";
            this.txtMaCTB.SelectedText = "";
            this.txtMaCTB.Size = new System.Drawing.Size(201, 34);
            this.txtMaCTB.TabIndex = 58;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Black;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Location = new System.Drawing.Point(27, 513);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(201, 34);
            this.txtTongTien.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnsuaCTDHB);
            this.groupBox2.Controls.Add(this.btnthemCTDHB);
            this.groupBox2.Controls.Add(this.btnhienThiCTDHB);
            this.groupBox2.Controls.Add(this.btnxoaCTDHB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(322, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 110);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnsuaCTDHB
            // 
            this.btnsuaCTDHB.AutoRoundedCorners = true;
            this.btnsuaCTDHB.BackColor = System.Drawing.Color.MistyRose;
            this.btnsuaCTDHB.BorderRadius = 22;
            this.btnsuaCTDHB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaCTDHB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaCTDHB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuaCTDHB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuaCTDHB.FillColor = System.Drawing.Color.RosyBrown;
            this.btnsuaCTDHB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsuaCTDHB.ForeColor = System.Drawing.Color.White;
            this.btnsuaCTDHB.Image = global::GUI.Properties.Resources.edit;
            this.btnsuaCTDHB.Location = new System.Drawing.Point(188, 37);
            this.btnsuaCTDHB.Name = "btnsuaCTDHB";
            this.btnsuaCTDHB.Size = new System.Drawing.Size(121, 46);
            this.btnsuaCTDHB.TabIndex = 64;
            this.btnsuaCTDHB.Text = "Sửa";
            this.btnsuaCTDHB.Click += new System.EventHandler(this.btnsuaCTDHB_Click);
            // 
            // btnthemCTDHB
            // 
            this.btnthemCTDHB.AutoRoundedCorners = true;
            this.btnthemCTDHB.BackColor = System.Drawing.Color.MistyRose;
            this.btnthemCTDHB.BorderRadius = 22;
            this.btnthemCTDHB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemCTDHB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemCTDHB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemCTDHB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemCTDHB.FillColor = System.Drawing.Color.RosyBrown;
            this.btnthemCTDHB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthemCTDHB.ForeColor = System.Drawing.Color.White;
            this.btnthemCTDHB.Image = global::GUI.Properties.Resources.plus;
            this.btnthemCTDHB.Location = new System.Drawing.Point(41, 37);
            this.btnthemCTDHB.Name = "btnthemCTDHB";
            this.btnthemCTDHB.Size = new System.Drawing.Size(121, 46);
            this.btnthemCTDHB.TabIndex = 63;
            this.btnthemCTDHB.Text = "Thêm";
            this.btnthemCTDHB.Click += new System.EventHandler(this.btnthemCTDHB_Click);
            // 
            // btnhienThiCTDHB
            // 
            this.btnhienThiCTDHB.AutoRoundedCorners = true;
            this.btnhienThiCTDHB.BackColor = System.Drawing.Color.MistyRose;
            this.btnhienThiCTDHB.BorderRadius = 22;
            this.btnhienThiCTDHB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiCTDHB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiCTDHB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhienThiCTDHB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhienThiCTDHB.FillColor = System.Drawing.Color.RosyBrown;
            this.btnhienThiCTDHB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhienThiCTDHB.ForeColor = System.Drawing.Color.White;
            this.btnhienThiCTDHB.Image = global::GUI.Properties.Resources.refresh;
            this.btnhienThiCTDHB.Location = new System.Drawing.Point(500, 37);
            this.btnhienThiCTDHB.Name = "btnhienThiCTDHB";
            this.btnhienThiCTDHB.Size = new System.Drawing.Size(121, 46);
            this.btnhienThiCTDHB.TabIndex = 66;
            this.btnhienThiCTDHB.Text = "Hiển Thị";
            this.btnhienThiCTDHB.Click += new System.EventHandler(this.btnhienThiCTDHB_Click);
            // 
            // btnxoaCTDHB
            // 
            this.btnxoaCTDHB.AutoRoundedCorners = true;
            this.btnxoaCTDHB.BackColor = System.Drawing.Color.MistyRose;
            this.btnxoaCTDHB.BorderRadius = 22;
            this.btnxoaCTDHB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaCTDHB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaCTDHB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoaCTDHB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoaCTDHB.FillColor = System.Drawing.Color.RosyBrown;
            this.btnxoaCTDHB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxoaCTDHB.ForeColor = System.Drawing.Color.White;
            this.btnxoaCTDHB.Image = global::GUI.Properties.Resources.trash;
            this.btnxoaCTDHB.Location = new System.Drawing.Point(352, 37);
            this.btnxoaCTDHB.Name = "btnxoaCTDHB";
            this.btnxoaCTDHB.Size = new System.Drawing.Size(121, 46);
            this.btnxoaCTDHB.TabIndex = 65;
            this.btnxoaCTDHB.Text = "Xóa";
            this.btnxoaCTDHB.Click += new System.EventHandler(this.btnxoaCTDHB_Click);
            // 
            // dgvCTDHB
            // 
            this.dgvCTDHB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTDHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDHB.Location = new System.Drawing.Point(328, 78);
            this.dgvCTDHB.Name = "dgvCTDHB";
            this.dgvCTDHB.RowHeadersWidth = 51;
            this.dgvCTDHB.RowTemplate.Height = 24;
            this.dgvCTDHB.Size = new System.Drawing.Size(689, 367);
            this.dgvCTDHB.TabIndex = 68;
            this.dgvCTDHB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTDHB_CellClick);
            // 
            // btntimKiemCTDHB
            // 
            this.btntimKiemCTDHB.AutoRoundedCorners = true;
            this.btntimKiemCTDHB.BackColor = System.Drawing.Color.MistyRose;
            this.btntimKiemCTDHB.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.btntimKiemCTDHB.BorderRadius = 22;
            this.btntimKiemCTDHB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemCTDHB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemCTDHB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimKiemCTDHB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimKiemCTDHB.FillColor = System.Drawing.Color.RosyBrown;
            this.btntimKiemCTDHB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimKiemCTDHB.ForeColor = System.Drawing.Color.White;
            this.btntimKiemCTDHB.Image = global::GUI.Properties.Resources.search;
            this.btntimKiemCTDHB.Location = new System.Drawing.Point(781, 17);
            this.btntimKiemCTDHB.Name = "btntimKiemCTDHB";
            this.btntimKiemCTDHB.Size = new System.Drawing.Size(121, 46);
            this.btntimKiemCTDHB.TabIndex = 73;
            this.btntimKiemCTDHB.Text = "Tìm kiếm";
            // 
            // txtTimCTB
            // 
            this.txtTimCTB.BackColor = System.Drawing.Color.Black;
            this.txtTimCTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimCTB.DefaultText = "";
            this.txtTimCTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimCTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimCTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimCTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimCTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimCTB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimCTB.ForeColor = System.Drawing.Color.Black;
            this.txtTimCTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimCTB.Location = new System.Drawing.Point(477, 29);
            this.txtTimCTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimCTB.Name = "txtTimCTB";
            this.txtTimCTB.PasswordChar = '\0';
            this.txtTimCTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTimCTB.PlaceholderText = "Nhập mã đơn hàng bán";
            this.txtTimCTB.SelectedText = "";
            this.txtTimCTB.Size = new System.Drawing.Size(280, 34);
            this.txtTimCTB.TabIndex = 72;
            this.txtTimCTB.TextChanged += new System.EventHandler(this.txtTimCTB_TextChanged);
            // 
            // GUI_ChitietDHB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.btntimKiemCTDHB);
            this.Controls.Add(this.txtTimCTB);
            this.Controls.Add(this.dgvCTDHB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_ChitietDHB";
            this.Text = "Chi tiết đơn hàng bán";
            this.Load += new System.EventHandler(this.GUI_ChitietDHB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDHB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnsuaCTDHB;
        private Guna.UI2.WinForms.Guna2Button btnthemCTDHB;
        private Guna.UI2.WinForms.Guna2Button btnhienThiCTDHB;
        private Guna.UI2.WinForms.Guna2Button btnxoaCTDHB;
        private System.Windows.Forms.DataGridView dgvCTDHB;
        private Guna.UI2.WinForms.Guna2Button btntimKiemCTDHB;
        private Guna.UI2.WinForms.Guna2TextBox txtTimCTB;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txttenLT;
        private Guna.UI2.WinForms.Guna2ComboBox txtmaLT;
        private Guna.UI2.WinForms.Guna2ComboBox txtmaDHB;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtsoLuong;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtgiaTien;
    }
}