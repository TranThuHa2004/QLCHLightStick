namespace GUI
{
    partial class GUI_BaoCao
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
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoLuongBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBaocao = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Từ ngày : ";
            // 
            // FromDate
            // 
            this.FromDate.Animated = true;
            this.FromDate.AutoRoundedCorners = true;
            this.FromDate.BackColor = System.Drawing.Color.Transparent;
            this.FromDate.BorderRadius = 17;
            this.FromDate.Checked = true;
            this.FromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDate.Location = new System.Drawing.Point(51, 42);
            this.FromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(249, 36);
            this.FromDate.TabIndex = 28;
            this.FromDate.Value = new System.DateTime(2024, 5, 22, 20, 34, 59, 48);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(30, 96);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 24;
            this.dgvBaoCao.Size = new System.Drawing.Size(931, 297);
            this.dgvBaoCao.TabIndex = 58;
            this.dgvBaoCao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellClick);
            this.dgvBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(692, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tổng lãi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(366, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tổng nhập : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(26, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tổng bán : ";
            // 
            // txtBan
            // 
            this.txtBan.AutoRoundedCorners = true;
            this.txtBan.BorderRadius = 22;
            this.txtBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBan.DefaultText = "0";
            this.txtBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBan.Location = new System.Drawing.Point(139, 410);
            this.txtBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBan.Name = "txtBan";
            this.txtBan.PasswordChar = '\0';
            this.txtBan.PlaceholderText = "";
            this.txtBan.SelectedText = "";
            this.txtBan.Size = new System.Drawing.Size(165, 46);
            this.txtBan.TabIndex = 62;
            // 
            // txtLai
            // 
            this.txtLai.AutoRoundedCorners = true;
            this.txtLai.BorderRadius = 22;
            this.txtLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLai.DefaultText = "0";
            this.txtLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLai.Location = new System.Drawing.Point(796, 410);
            this.txtLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLai.Name = "txtLai";
            this.txtLai.PasswordChar = '\0';
            this.txtLai.PlaceholderText = "";
            this.txtLai.SelectedText = "";
            this.txtLai.Size = new System.Drawing.Size(165, 46);
            this.txtLai.TabIndex = 63;
            // 
            // txtNhap
            // 
            this.txtNhap.AutoRoundedCorners = true;
            this.txtNhap.BorderRadius = 22;
            this.txtNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhap.DefaultText = "0";
            this.txtNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhap.Location = new System.Drawing.Point(490, 410);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.PasswordChar = '\0';
            this.txtNhap.PlaceholderText = "";
            this.txtNhap.SelectedText = "";
            this.txtNhap.Size = new System.Drawing.Size(165, 46);
            this.txtNhap.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(26, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "Số lượng hóa đơn bán : ";
            // 
            // txtsoLuongBan
            // 
            this.txtsoLuongBan.AutoRoundedCorners = true;
            this.txtsoLuongBan.BorderRadius = 22;
            this.txtsoLuongBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoLuongBan.DefaultText = "0";
            this.txtsoLuongBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsoLuongBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsoLuongBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoLuongBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoLuongBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoLuongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsoLuongBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoLuongBan.Location = new System.Drawing.Point(246, 487);
            this.txtsoLuongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoLuongBan.Name = "txtsoLuongBan";
            this.txtsoLuongBan.PasswordChar = '\0';
            this.txtsoLuongBan.PlaceholderText = "";
            this.txtsoLuongBan.SelectedText = "";
            this.txtsoLuongBan.Size = new System.Drawing.Size(181, 46);
            this.txtsoLuongBan.TabIndex = 66;
            this.txtsoLuongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBaocao
            // 
            this.btnBaocao.AutoRoundedCorners = true;
            this.btnBaocao.BorderRadius = 25;
            this.btnBaocao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaocao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaocao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaocao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaocao.FillColor = System.Drawing.Color.RosyBrown;
            this.btnBaocao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaocao.ForeColor = System.Drawing.Color.White;
            this.btnBaocao.Location = new System.Drawing.Point(753, 25);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(135, 53);
            this.btnBaocao.TabIndex = 67;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(447, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Đến ngày : ";
            // 
            // ToDate
            // 
            this.ToDate.Animated = true;
            this.ToDate.AutoRoundedCorners = true;
            this.ToDate.BorderRadius = 17;
            this.ToDate.Checked = true;
            this.ToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDate.Location = new System.Drawing.Point(451, 42);
            this.ToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(249, 36);
            this.ToDate.TabIndex = 28;
            this.ToDate.Value = new System.DateTime(2024, 5, 22, 20, 34, 59, 48);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(487, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Số lượng hóa đơn nhập : ";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.AutoRoundedCorners = true;
            this.txtSoLuongNhap.BorderRadius = 22;
            this.txtSoLuongNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongNhap.DefaultText = "0";
            this.txtSoLuongNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(718, 487);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.PasswordChar = '\0';
            this.txtSoLuongNhap.PlaceholderText = "";
            this.txtSoLuongNhap.SelectedText = "";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(181, 46);
            this.txtSoLuongNhap.TabIndex = 66;
            this.txtSoLuongNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GUI_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1029, 556);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoLuongBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.txtLai);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "GUI_BaoCao";
            this.Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBan;
        private Guna.UI2.WinForms.Guna2TextBox txtLai;
        private Guna.UI2.WinForms.Guna2TextBox txtNhap;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtsoLuongBan;
        private Guna.UI2.WinForms.Guna2Button btnBaocao;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongNhap;
    }
}