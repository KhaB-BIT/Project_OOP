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
            this.lbDevices = new System.Windows.Forms.Label();
            this.cbbDevices = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnSdtKH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
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
            this.txtCheck.Location = new System.Drawing.Point(77, 908);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(5);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(245, 20);
            this.txtCheck.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.pictureBox2.Location = new System.Drawing.Point(65, 899);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 39);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // lbDevices
            // 
            this.lbDevices.AutoSize = true;
            this.lbDevices.Font = new System.Drawing.Font("r0c0i Linotte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevices.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbDevices.Location = new System.Drawing.Point(60, 956);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(59, 25);
            this.lbDevices.TabIndex = 49;
            this.lbDevices.Text = "Error";
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
            this.cbbDevices.Location = new System.Drawing.Point(65, 984);
            this.cbbDevices.Name = "cbbDevices";
            this.cbbDevices.Size = new System.Drawing.Size(269, 27);
            this.cbbDevices.Sorted = true;
            this.cbbDevices.TabIndex = 48;
            this.cbbDevices.Text = "Thiết bị Camera";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("r0c0i Linotte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(615, 111);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 39);
            this.button4.TabIndex = 47;
            this.button4.Text = "Nhập";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("r0c0i Linotte", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(1577, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 39);
            this.button3.TabIndex = 46;
            this.button3.Text = "Xóa sản phẩm";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.btnXuatHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("r0c0i Linotte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.btnXuatHoaDon.Location = new System.Drawing.Point(302, 268);
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
            this.btnSdtKH.Location = new System.Drawing.Point(302, 185);
            this.btnSdtKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSdtKH.Name = "btnSdtKH";
            this.btnSdtKH.Size = new System.Drawing.Size(298, 39);
            this.btnSdtKH.TabIndex = 44;
            this.btnSdtKH.Text = "Nhập SĐT Khách hàng";
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
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.AccessibleDescription = "";
            this.txtTimKiemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.txtTimKiemNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemNV.Font = new System.Drawing.Font("r0c0i Linotte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(231)))), ((int)(((byte)(192)))));
            this.txtTimKiemNV.Location = new System.Drawing.Point(314, 120);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(274, 20);
            this.txtTimKiemNV.TabIndex = 41;
            this.txtTimKiemNV.Text = "Nhập mã sản phẩm hoặc series";
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
            this.dataHoaDon.Location = new System.Drawing.Point(772, 120);
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
            this.dataHoaDon.Size = new System.Drawing.Size(1103, 891);
            this.dataHoaDon.TabIndex = 40;
            this.dataHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataHoaDon_RowsAdded);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.cbbDevices);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.btnSdtKH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiemNV);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbDevices;
        private System.Windows.Forms.ComboBox cbbDevices;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnSdtKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataHoaDon;
    }
}