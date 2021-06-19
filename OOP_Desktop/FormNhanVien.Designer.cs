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
            this.cbbDevices = new System.Windows.Forms.ComboBox();
            this.btnNhapMaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnNhapSDT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnChiTietNV = new System.Windows.Forms.Button();
            this.btnChiTietKH = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptbCheck = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TimeNgay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.txtCheck.Location = new System.Drawing.Point(44, 597);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(5);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.ReadOnly = true;
            this.txtCheck.Size = new System.Drawing.Size(168, 20);
            this.txtCheck.TabIndex = 50;
            this.txtCheck.Text = "Barcode";
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
            this.cbbDevices.Location = new System.Drawing.Point(32, 633);
            this.cbbDevices.Name = "cbbDevices";
            this.cbbDevices.Size = new System.Drawing.Size(192, 27);
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
            this.btnNhapMaSP.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnNhapMaSP.Location = new System.Drawing.Point(304, 200);
            this.btnNhapMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapMaSP.Name = "btnNhapMaSP";
            this.btnNhapMaSP.Size = new System.Drawing.Size(68, 39);
            this.btnNhapMaSP.TabIndex = 47;
            this.btnNhapMaSP.Text = "Nhập";
            this.btnNhapMaSP.UseVisualStyleBackColor = false;
            this.btnNhapMaSP.Click += new System.EventHandler(this.btnNhapMaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnXoaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("r0c0i Linotte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnXoaSP.Location = new System.Drawing.Point(388, 593);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(184, 39);
            this.btnXoaSP.TabIndex = 46;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.btnXuatHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(32, 393);
            this.btnXuatHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(261, 39);
            this.btnXuatHoaDon.TabIndex = 45;
            this.btnXuatHoaDon.Text = "Xuất hoá đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnThemKH.Location = new System.Drawing.Point(32, 324);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(261, 32);
            this.btnThemKH.TabIndex = 44;
            this.btnThemKH.Text = "Thêm khách hàng mới";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.AccessibleDescription = "";
            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSP.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtMaSP.Location = new System.Drawing.Point(44, 210);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(237, 20);
            this.txtMaSP.TabIndex = 41;
            this.txtMaSP.Text = "Nhập mã sản phẩm hoặc series*";
            this.txtMaSP.Click += new System.EventHandler(this.txtMaSP_Click);
            this.txtMaSP.Leave += new System.EventHandler(this.txtMaSP_Leave);
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
            this.dataHoaDon.Location = new System.Drawing.Point(388, 200);
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
            this.dataHoaDon.Size = new System.Drawing.Size(651, 371);
            this.dataHoaDon.TabIndex = 40;
            this.dataHoaDon.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataHoaDon_CellBeginEdit);
            this.dataHoaDon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDon_CellEndEdit);
            this.dataHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataHoaDon_RowsAdded);
            this.dataHoaDon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataHoaDon_RowsRemoved);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AccessibleDescription = "";
            this.txtThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThanhTien.Font = new System.Drawing.Font("r0c0i Linotte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.White;
            this.txtThanhTien.Location = new System.Drawing.Point(753, 626);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(274, 29);
            this.txtThanhTien.TabIndex = 53;
            this.txtThanhTien.Text = "VNĐ";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNhapSDT
            // 
            this.btnNhapSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnNhapSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhapSDT.FlatAppearance.BorderSize = 0;
            this.btnNhapSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapSDT.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnNhapSDT.Location = new System.Drawing.Point(304, 277);
            this.btnNhapSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapSDT.Name = "btnNhapSDT";
            this.btnNhapSDT.Size = new System.Drawing.Size(68, 39);
            this.btnNhapSDT.TabIndex = 57;
            this.btnNhapSDT.Text = "Nhập";
            this.btnNhapSDT.UseVisualStyleBackColor = false;
            this.btnNhapSDT.Click += new System.EventHandler(this.btnNhapSDT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("r0c0i Linotte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(907, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "THÀNH TIỀN";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AccessibleDescription = "";
            this.txtSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienThoai.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtSoDienThoai.Location = new System.Drawing.Point(44, 287);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(237, 20);
            this.txtSoDienThoai.TabIndex = 55;
            this.txtSoDienThoai.Text = "Nhập số điện thoại khách hàng*";
            this.txtSoDienThoai.Click += new System.EventHandler(this.txtSoDienThoai_Click);
            this.txtSoDienThoai.Leave += new System.EventHandler(this.txtSoDienThoai_Leave);
            // 
            // txtDate
            // 
            this.txtDate.AccessibleDescription = "";
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtDate.Location = new System.Drawing.Point(400, 62);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(92, 20);
            this.txtDate.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(384, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "NGÀY XUẤT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(561, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "THÔNG TIN NHÂN VIÊN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(823, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "THÔNG TIN KHÁCH HÀNG:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.AccessibleDescription = "";
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtMaNV.Location = new System.Drawing.Point(577, 62);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(179, 20);
            this.txtMaNV.TabIndex = 64;
            // 
            // txtTenNV
            // 
            this.txtTenNV.AccessibleDescription = "";
            this.txtTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNV.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtTenNV.Location = new System.Drawing.Point(577, 107);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(179, 20);
            this.txtTenNV.TabIndex = 66;
            // 
            // txtTenKH
            // 
            this.txtTenKH.AccessibleDescription = "";
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKH.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtTenKH.Location = new System.Drawing.Point(840, 107);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(184, 20);
            this.txtTenKH.TabIndex = 70;
            // 
            // txtMaKH
            // 
            this.txtMaKH.AccessibleDescription = "";
            this.txtMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.txtMaKH.Location = new System.Drawing.Point(840, 62);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(184, 20);
            this.txtMaKH.TabIndex = 68;
            // 
            // btnChiTietNV
            // 
            this.btnChiTietNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnChiTietNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChiTietNV.FlatAppearance.BorderSize = 0;
            this.btnChiTietNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietNV.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnChiTietNV.Location = new System.Drawing.Point(658, 142);
            this.btnChiTietNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTietNV.Name = "btnChiTietNV";
            this.btnChiTietNV.Size = new System.Drawing.Size(110, 28);
            this.btnChiTietNV.TabIndex = 72;
            this.btnChiTietNV.Text = "Xem chi tiết";
            this.btnChiTietNV.UseVisualStyleBackColor = false;
            this.btnChiTietNV.Click += new System.EventHandler(this.btnChiTietNV_Click);
            // 
            // btnChiTietKH
            // 
            this.btnChiTietKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnChiTietKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChiTietKH.FlatAppearance.BorderSize = 0;
            this.btnChiTietKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietKH.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnChiTietKH.Location = new System.Drawing.Point(926, 142);
            this.btnChiTietKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTietKH.Name = "btnChiTietKH";
            this.btnChiTietKH.Size = new System.Drawing.Size(110, 28);
            this.btnChiTietKH.TabIndex = 73;
            this.btnChiTietKH.Text = "Xem chi tiết";
            this.btnChiTietKH.UseVisualStyleBackColor = false;
            this.btnChiTietKH.Click += new System.EventHandler(this.btnChiTietKH_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox9.Location = new System.Drawing.Point(828, 101);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(208, 33);
            this.pictureBox9.TabIndex = 71;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox10.Location = new System.Drawing.Point(828, 56);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(208, 33);
            this.pictureBox10.TabIndex = 69;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox8.Location = new System.Drawing.Point(565, 101);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(203, 33);
            this.pictureBox8.TabIndex = 67;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox7.Location = new System.Drawing.Point(565, 56);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(203, 33);
            this.pictureBox7.TabIndex = 65;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox6.Location = new System.Drawing.Point(388, 56);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(116, 33);
            this.pictureBox6.TabIndex = 60;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox4.Location = new System.Drawing.Point(32, 200);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 39);
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.pictureBox3.Location = new System.Drawing.Point(741, 621);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 39);
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // ptbCheck
            // 
            this.ptbCheck.Location = new System.Drawing.Point(32, 474);
            this.ptbCheck.Name = "ptbCheck";
            this.ptbCheck.Size = new System.Drawing.Size(192, 108);
            this.ptbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCheck.TabIndex = 52;
            this.ptbCheck.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.pictureBox2.Location = new System.Drawing.Point(32, 588);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 39);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OOP_Desktop.Properties.Resources.FinalPng;
            this.pictureBox1.InitialImage = global::OOP_Desktop.Properties.Resources.FinalPng;
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pictureBox5.Location = new System.Drawing.Point(32, 277);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(261, 39);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // TimeNgay
            // 
            this.TimeNgay.Interval = 60000;
            this.TimeNgay.Tick += new System.EventHandler(this.TimeNgay_Tick);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnChiTietKH);
            this.Controls.Add(this.btnChiTietNV);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhapSDT);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ptbCheck);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbbDevices);
            this.Controls.Add(this.btnNhapMaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataHoaDon);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSmart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.PictureBox ptbCheck;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnNhapSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button btnChiTietNV;
        private System.Windows.Forms.Button btnChiTietKH;
        private System.Windows.Forms.Timer TimeNgay;
    }
}