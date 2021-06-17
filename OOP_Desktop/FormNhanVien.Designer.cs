namespace OOP_Desktop
{
    partial class FormNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbbDevices = new System.Windows.Forms.ComboBox();
            this.btnNhapMaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnSdtKH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.ptbCheck = new System.Windows.Forms.PictureBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnNhapSDT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCheck
            // 
            this.txtCheck.AccessibleDescription = "";
            this.txtCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.txtCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheck.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.txtCheck.Location = new System.Drawing.Point(326, 675);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(5);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(245, 20);
            this.txtCheck.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.pictureBox2.Location = new System.Drawing.Point(314, 666);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 39);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // cbbDevices
            // 
            this.cbbDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.cbbDevices.DropDownHeight = 160;
            this.cbbDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDevices.Font = new System.Drawing.Font("r0c0i Linotte", 12F);
            this.cbbDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.cbbDevices.FormattingEnabled = true;
            this.cbbDevices.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbbDevices.IntegralHeight = false;
            this.cbbDevices.ItemHeight = 19;
            this.cbbDevices.Location = new System.Drawing.Point(314, 726);
            this.cbbDevices.Name = "cbbDevices";
            this.cbbDevices.Size = new System.Drawing.Size(269, 27);
            this.cbbDevices.Sorted = true;
            this.cbbDevices.TabIndex = 48;
            this.cbbDevices.Text = "Thiết bị Camera";
            this.cbbDevices.SelectionChangeCommitted += new System.EventHandler(this.cbbDevices_SelectionChangeCommitted);
            // 
            // btnNhapMaSP
            // 
            this.btnNhapMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnNhapMaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhapMaSP.FlatAppearance.BorderSize = 0;
            this.btnNhapMaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapMaSP.Font = new System.Drawing.Font("r0c0i Linotte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnNhapMaSP.Location = new System.Drawing.Point(615, 111);
            this.btnNhapMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapMaSP.Name = "btnNhapMaSP";
            this.btnNhapMaSP.Size = new System.Drawing.Size(105, 39);
            this.btnNhapMaSP.TabIndex = 47;
            this.btnNhapMaSP.Text = "Nhập";
            this.btnNhapMaSP.UseVisualStyleBackColor = false;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnXoaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("r0c0i Linotte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnXoaSP.Location = new System.Drawing.Point(772, 836);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(298, 39);
            this.btnXoaSP.TabIndex = 46;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnXuatHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnXuatHoaDon.Location = new System.Drawing.Point(302, 326);
            this.btnXuatHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(298, 39);
            this.btnXuatHoaDon.TabIndex = 45;
            this.btnXuatHoaDon.Text = "Xuất hoá đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnSdtKH
            // 
            this.btnSdtKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnSdtKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSdtKH.FlatAppearance.BorderSize = 0;
            this.btnSdtKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSdtKH.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdtKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnSdtKH.Location = new System.Drawing.Point(302, 237);
            this.btnSdtKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSdtKH.Name = "btnSdtKH";
            this.btnSdtKH.Size = new System.Drawing.Size(298, 39);
            this.btnSdtKH.TabIndex = 44;
            this.btnSdtKH.Text = "Thêm khách hàng mới";
            this.btnSdtKH.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OOP_Desktop.Properties.Resources.FinalPng;
            this.pictureBox1.InitialImage = global::OOP_Desktop.Properties.Resources.FinalPng;
            this.pictureBox1.Location = new System.Drawing.Point(29, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaSP
            // 
            this.txtMaSP.AccessibleDescription = "";
            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSP.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.txtMaSP.Location = new System.Drawing.Point(314, 119);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(274, 23);
            this.txtMaSP.TabIndex = 41;
            this.txtMaSP.Text = "Nhập mã sản phẩm hoặc series";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.pictureBox5.Location = new System.Drawing.Point(302, 111);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(298, 39);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToAddRows = false;
            this.dataHoaDon.AllowUserToDeleteRows = false;
            this.dataHoaDon.AllowUserToResizeColumns = false;
            this.dataHoaDon.AllowUserToResizeRows = false;
            this.dataHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.dataHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHoaDon.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHoaDon.EnableHeadersVisualStyles = false;
            this.dataHoaDon.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataHoaDon.Location = new System.Drawing.Point(772, 111);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.ReadOnly = true;
            this.dataHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataHoaDon.Size = new System.Drawing.Size(800, 651);
            this.dataHoaDon.TabIndex = 40;
            this.dataHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataHoaDon_RowsAdded);
            // 
            // ptbCheck
            // 
            this.ptbCheck.Location = new System.Drawing.Point(314, 478);
            this.ptbCheck.Name = "ptbCheck";
            this.ptbCheck.Size = new System.Drawing.Size(269, 166);
            this.ptbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCheck.TabIndex = 52;
            this.ptbCheck.TabStop = false;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AccessibleDescription = "";
            this.txtThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThanhTien.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.White;
            this.txtThanhTien.Location = new System.Drawing.Point(1283, 844);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(274, 23);
            this.txtThanhTien.TabIndex = 53;
            this.txtThanhTien.Text = "VNĐ";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.pictureBox3.Location = new System.Drawing.Point(1274, 836);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 39);
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AccessibleDescription = "";
            this.txtSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienThoai.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(314, 201);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(274, 23);
            this.txtSoDienThoai.TabIndex = 55;
            this.txtSoDienThoai.Text = "Nhập số điện thoại khách hàng";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.pictureBox4.Location = new System.Drawing.Point(302, 193);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(298, 39);
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // btnNhapSDT
            // 
            this.btnNhapSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnNhapSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhapSDT.FlatAppearance.BorderSize = 0;
            this.btnNhapSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapSDT.Font = new System.Drawing.Font("r0c0i Linotte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnNhapSDT.Location = new System.Drawing.Point(615, 193);
            this.btnNhapSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapSDT.Name = "btnNhapSDT";
            this.btnNhapSDT.Size = new System.Drawing.Size(105, 39);
            this.btnNhapSDT.TabIndex = 57;
            this.btnNhapSDT.Text = "Nhập";
            this.btnNhapSDT.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("r0c0i Linotte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1269, 796);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "THÀNH TIỀN";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhapSDT);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ptbCheck);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbbDevices);
            this.Controls.Add(this.btnNhapMaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.btnSdtKH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataHoaDon);
            this.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbbDevices;
        private System.Windows.Forms.Button btnNhapMaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnSdtKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.PictureBox ptbCheck;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnNhapSDT;
        private System.Windows.Forms.Label label1;
    }
}