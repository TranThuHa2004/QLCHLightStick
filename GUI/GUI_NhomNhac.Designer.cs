namespace GUI
{
    partial class GUI_NhomNhac
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
            this.dgvNN = new System.Windows.Forms.DataGridView();
            this.btntimKiemNN = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemNN = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuaNN = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoaNN = new Guna.UI2.WinForms.Guna2Button();
            this.btnhienThiNN = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimNN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenNN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmaNN = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // dgvNN
            // 
            this.dgvNN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNN.Location = new System.Drawing.Point(331, 91);
            this.dgvNN.Name = "dgvNN";
            this.dgvNN.RowHeadersWidth = 51;
            this.dgvNN.RowTemplate.Height = 24;
            this.dgvNN.Size = new System.Drawing.Size(686, 364);
            this.dgvNN.TabIndex = 58;
            this.dgvNN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNN_CellClick);
            // 
            // btntimKiemNN
            // 
            this.btntimKiemNN.AutoRoundedCorners = true;
            this.btntimKiemNN.BackColor = System.Drawing.Color.MistyRose;
            this.btntimKiemNN.BackgroundImage = global::GUI.Properties.Resources.Màu_kem_Màu_Trơn_Biểu_tượng_Hình_nền_Màn_hình_chính;
            this.btntimKiemNN.BorderRadius = 22;
            this.btntimKiemNN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemNN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimKiemNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimKiemNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimKiemNN.FillColor = System.Drawing.Color.RosyBrown;
            this.btntimKiemNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimKiemNN.ForeColor = System.Drawing.Color.White;
            this.btntimKiemNN.Image = global::GUI.Properties.Resources.search;
            this.btntimKiemNN.Location = new System.Drawing.Point(707, 30);
            this.btntimKiemNN.Name = "btntimKiemNN";
            this.btntimKiemNN.Size = new System.Drawing.Size(121, 46);
            this.btntimKiemNN.TabIndex = 59;
            this.btntimKiemNN.Text = "Tìm kiếm";
            // 
            // btnthemNN
            // 
            this.btnthemNN.AutoRoundedCorners = true;
            this.btnthemNN.BackColor = System.Drawing.Color.MistyRose;
            this.btnthemNN.BorderRadius = 22;
            this.btnthemNN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemNN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemNN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnthemNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthemNN.ForeColor = System.Drawing.Color.White;
            this.btnthemNN.Image = global::GUI.Properties.Resources.plus;
            this.btnthemNN.Location = new System.Drawing.Point(16, 31);
            this.btnthemNN.Name = "btnthemNN";
            this.btnthemNN.Size = new System.Drawing.Size(121, 46);
            this.btnthemNN.TabIndex = 60;
            this.btnthemNN.Text = "Thêm";
            this.btnthemNN.Click += new System.EventHandler(this.btnthemNN_Click);
            // 
            // btnsuaNN
            // 
            this.btnsuaNN.AutoRoundedCorners = true;
            this.btnsuaNN.BackColor = System.Drawing.Color.MistyRose;
            this.btnsuaNN.BorderRadius = 22;
            this.btnsuaNN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaNN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuaNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuaNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuaNN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnsuaNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsuaNN.ForeColor = System.Drawing.Color.White;
            this.btnsuaNN.Image = global::GUI.Properties.Resources.edit;
            this.btnsuaNN.Location = new System.Drawing.Point(146, 31);
            this.btnsuaNN.Name = "btnsuaNN";
            this.btnsuaNN.Size = new System.Drawing.Size(121, 46);
            this.btnsuaNN.TabIndex = 61;
            this.btnsuaNN.Text = "Sửa";
            this.btnsuaNN.Click += new System.EventHandler(this.btnsuaNN_Click);
            // 
            // btnxoaNN
            // 
            this.btnxoaNN.AutoRoundedCorners = true;
            this.btnxoaNN.BackColor = System.Drawing.Color.MistyRose;
            this.btnxoaNN.BorderRadius = 22;
            this.btnxoaNN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaNN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoaNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoaNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoaNN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnxoaNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxoaNN.ForeColor = System.Drawing.Color.White;
            this.btnxoaNN.Image = global::GUI.Properties.Resources.trash;
            this.btnxoaNN.Location = new System.Drawing.Point(290, 31);
            this.btnxoaNN.Name = "btnxoaNN";
            this.btnxoaNN.Size = new System.Drawing.Size(121, 46);
            this.btnxoaNN.TabIndex = 62;
            this.btnxoaNN.Text = "Xóa";
            this.btnxoaNN.Click += new System.EventHandler(this.btnxoaNN_Click);
            // 
            // btnhienThiNN
            // 
            this.btnhienThiNN.AutoRoundedCorners = true;
            this.btnhienThiNN.BackColor = System.Drawing.Color.MistyRose;
            this.btnhienThiNN.BorderRadius = 22;
            this.btnhienThiNN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiNN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhienThiNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhienThiNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhienThiNN.FillColor = System.Drawing.Color.RosyBrown;
            this.btnhienThiNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhienThiNN.ForeColor = System.Drawing.Color.White;
            this.btnhienThiNN.Image = global::GUI.Properties.Resources.refresh;
            this.btnhienThiNN.Location = new System.Drawing.Point(437, 31);
            this.btnhienThiNN.Name = "btnhienThiNN";
            this.btnhienThiNN.Size = new System.Drawing.Size(121, 46);
            this.btnhienThiNN.TabIndex = 63;
            this.btnhienThiNN.Text = "Hiển Thị";
            this.btnhienThiNN.Click += new System.EventHandler(this.btnhienThiNN_Click);
            // 
            // txtTimNN
            // 
            this.txtTimNN.BackColor = System.Drawing.Color.Black;
            this.txtTimNN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimNN.DefaultText = "";
            this.txtTimNN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimNN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimNN.ForeColor = System.Drawing.Color.Black;
            this.txtTimNN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimNN.Location = new System.Drawing.Point(420, 42);
            this.txtTimNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimNN.Name = "txtTimNN";
            this.txtTimNN.PasswordChar = '\0';
            this.txtTimNN.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTimNN.PlaceholderText = "Nhập tên or mã nhóm nhạc";
            this.txtTimNN.SelectedText = "";
            this.txtTimNN.Size = new System.Drawing.Size(280, 34);
            this.txtTimNN.TabIndex = 64;
            this.txtTimNN.TextChanged += new System.EventHandler(this.txtTimNN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(6, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mã NCC : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tên NN : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 67;
            this.label3.Text = "Mã NN : ";
            // 
            // txtmaNCC
            // 
            this.txtmaNCC.BackColor = System.Drawing.Color.Black;
            this.txtmaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaNCC.DefaultText = "";
            this.txtmaNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmaNCC.ForeColor = System.Drawing.Color.Black;
            this.txtmaNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaNCC.Location = new System.Drawing.Point(106, 259);
            this.txtmaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaNCC.Name = "txtmaNCC";
            this.txtmaNCC.PasswordChar = '\0';
            this.txtmaNCC.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtmaNCC.PlaceholderText = "";
            this.txtmaNCC.SelectedText = "";
            this.txtmaNCC.Size = new System.Drawing.Size(201, 34);
            this.txtmaNCC.TabIndex = 68;
            // 
            // txttenNN
            // 
            this.txttenNN.BackColor = System.Drawing.Color.Black;
            this.txttenNN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenNN.DefaultText = "";
            this.txttenNN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenNN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenNN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenNN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenNN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenNN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttenNN.ForeColor = System.Drawing.Color.Black;
            this.txttenNN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenNN.Location = new System.Drawing.Point(102, 146);
            this.txttenNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenNN.Name = "txttenNN";
            this.txttenNN.PasswordChar = '\0';
            this.txttenNN.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txttenNN.PlaceholderText = "";
            this.txttenNN.SelectedText = "";
            this.txttenNN.Size = new System.Drawing.Size(201, 34);
            this.txttenNN.TabIndex = 69;
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
            this.txtmaNN.Location = new System.Drawing.Point(102, 42);
            this.txtmaNN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaNN.Name = "txtmaNN";
            this.txtmaNN.PasswordChar = '\0';
            this.txtmaNN.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtmaNN.PlaceholderText = "";
            this.txtmaNN.SelectedText = "";
            this.txtmaNN.Size = new System.Drawing.Size(201, 34);
            this.txtmaNN.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmaNCC);
            this.groupBox1.Controls.Add(this.txttenNN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmaNN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 561);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhóm nhạc";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnthemNN);
            this.groupBox2.Controls.Add(this.btnsuaNN);
            this.groupBox2.Controls.Add(this.btnxoaNN);
            this.groupBox2.Controls.Add(this.btnhienThiNN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(325, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 100);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // GUI_NhomNhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimNN);
            this.Controls.Add(this.btntimKiemNN);
            this.Controls.Add(this.dgvNN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_NhomNhac";
            this.Text = "GUI_NhomNhac";
            this.Load += new System.EventHandler(this.GUI_NhomNhac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvNN;
        private Guna.UI2.WinForms.Guna2Button btntimKiemNN;
        private Guna.UI2.WinForms.Guna2Button btnthemNN;
        private Guna.UI2.WinForms.Guna2Button btnsuaNN;
        private Guna.UI2.WinForms.Guna2Button btnxoaNN;
        private Guna.UI2.WinForms.Guna2Button btnhienThiNN;
        private Guna.UI2.WinForms.Guna2TextBox txtTimNN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtmaNCC;
        private Guna.UI2.WinForms.Guna2TextBox txttenNN;
        private Guna.UI2.WinForms.Guna2TextBox txtmaNN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}