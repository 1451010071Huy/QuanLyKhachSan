namespace Quanlykhachsan
{
    partial class FormPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lsvLoaiPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabctrPhong = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.cmbTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lsvPhong = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabLoaiphong = new System.Windows.Forms.TabPage();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnQLVT = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.txtSonguoi = new System.Windows.Forms.TextBox();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabctrPhong.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.tabLoaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(32, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số người:";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(35, 64);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(206, 20);
            this.txtMaloai.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(35, 126);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(206, 20);
            this.txtGia.TabIndex = 3;
            this.txtGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGia_KeyDown);
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // lsvLoaiPhong
            // 
            this.lsvLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvLoaiPhong.FullRowSelect = true;
            this.lsvLoaiPhong.GridLines = true;
            this.lsvLoaiPhong.Location = new System.Drawing.Point(284, 3);
            this.lsvLoaiPhong.MultiSelect = false;
            this.lsvLoaiPhong.Name = "lsvLoaiPhong";
            this.lsvLoaiPhong.Size = new System.Drawing.Size(417, 298);
            this.lsvLoaiPhong.TabIndex = 8;
            this.lsvLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lsvLoaiPhong.View = System.Windows.Forms.View.Details;
            this.lsvLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.lsvLoaiPhong_SelectedIndexChanged);
            this.lsvLoaiPhong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvLoaiPhong_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã loại";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số người";
            this.columnHeader4.Width = 101;
            // 
            // tabctrPhong
            // 
            this.tabctrPhong.Controls.Add(this.tabPhong);
            this.tabctrPhong.Controls.Add(this.tabLoaiphong);
            this.tabctrPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrPhong.Location = new System.Drawing.Point(0, 3);
            this.tabctrPhong.Name = "tabctrPhong";
            this.tabctrPhong.SelectedIndex = 0;
            this.tabctrPhong.Size = new System.Drawing.Size(753, 411);
            this.tabctrPhong.TabIndex = 19;
            this.tabctrPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabctrPhong_MouseClick);
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.btnSuaPhong);
            this.tabPhong.Controls.Add(this.btnXoaPhong);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.lb_title);
            this.tabPhong.Controls.Add(this.cmbTenLoaiPhong);
            this.tabPhong.Controls.Add(this.label7);
            this.tabPhong.Controls.Add(this.lsvPhong);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.label5);
            this.tabPhong.Location = new System.Drawing.Point(4, 22);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(745, 385);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Quản Lý Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuaPhong.Location = new System.Drawing.Point(203, 263);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(75, 33);
            this.btnSuaPhong.TabIndex = 36;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoaPhong.Location = new System.Drawing.Point(122, 263);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(75, 33);
            this.btnXoaPhong.TabIndex = 35;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemPhong.Location = new System.Drawing.Point(36, 263);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(75, 33);
            this.btnThemPhong.TabIndex = 34;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.Maroon;
            this.lb_title.Location = new System.Drawing.Point(22, 17);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(162, 20);
            this.lb_title.TabIndex = 33;
            this.lb_title.Text = "QUẢN LÝ PHÒNG";
            // 
            // cmbTenLoaiPhong
            // 
            this.cmbTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLoaiPhong.FormattingEnabled = true;
            this.cmbTenLoaiPhong.Location = new System.Drawing.Point(33, 204);
            this.cmbTenLoaiPhong.Name = "cmbTenLoaiPhong";
            this.cmbTenLoaiPhong.Size = new System.Drawing.Size(258, 21);
            this.cmbTenLoaiPhong.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(33, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Loại Phòng";
            // 
            // lsvPhong
            // 
            this.lsvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPhong.FullRowSelect = true;
            this.lsvPhong.GridLines = true;
            this.lsvPhong.Location = new System.Drawing.Point(331, 6);
            this.lsvPhong.MultiSelect = false;
            this.lsvPhong.Name = "lsvPhong";
            this.lsvPhong.Size = new System.Drawing.Size(396, 375);
            this.lsvPhong.TabIndex = 17;
            this.lsvPhong.UseCompatibleStateImageBehavior = false;
            this.lsvPhong.View = System.Windows.Forms.View.Details;
            this.lsvPhong.Click += new System.EventHandler(this.lsvPhong_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phòng";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại phòng";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số Người";
            this.columnHeader7.Width = 99;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá";
            this.columnHeader8.Width = 80;
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(33, 115);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(258, 20);
            this.txtPhong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phòng:";
            // 
            // tabLoaiphong
            // 
            this.tabLoaiphong.Controls.Add(this.btnXoaLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.btnSuaLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.btnQLVT);
            this.tabLoaiphong.Controls.Add(this.btnThemLoaiPhong);
            this.tabLoaiphong.Controls.Add(this.txtSonguoi);
            this.tabLoaiphong.Controls.Add(this.label1);
            this.tabLoaiphong.Controls.Add(this.label3);
            this.tabLoaiphong.Controls.Add(this.label4);
            this.tabLoaiphong.Controls.Add(this.txtMaloai);
            this.tabLoaiphong.Controls.Add(this.txtGia);
            this.tabLoaiphong.Controls.Add(this.lsvLoaiPhong);
            this.tabLoaiphong.Location = new System.Drawing.Point(4, 22);
            this.tabLoaiphong.Name = "tabLoaiphong";
            this.tabLoaiphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiphong.Size = new System.Drawing.Size(745, 385);
            this.tabLoaiphong.TabIndex = 1;
            this.tabLoaiphong.Text = "Loại Phòng";
            this.tabLoaiphong.UseVisualStyleBackColor = true;
            this.tabLoaiphong.Click += new System.EventHandler(this.tabLoaiphong_Click);
            this.tabLoaiphong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabLoaiphong_MouseClick);
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(180, 231);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(61, 31);
            this.btnXoaLoaiPhong.TabIndex = 14;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(113, 231);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(61, 31);
            this.btnSuaLoaiPhong.TabIndex = 13;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // btnQLVT
            // 
            this.btnQLVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQLVT.Location = new System.Drawing.Point(46, 278);
            this.btnQLVT.Name = "btnQLVT";
            this.btnQLVT.Size = new System.Drawing.Size(195, 23);
            this.btnQLVT.TabIndex = 11;
            this.btnQLVT.Text = "Quản lý vật tư";
            this.btnQLVT.UseVisualStyleBackColor = true;
            this.btnQLVT.Click += new System.EventHandler(this.btnQLVT_Click);
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(46, 231);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(61, 31);
            this.btnThemLoaiPhong.TabIndex = 9;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // txtSonguoi
            // 
            this.txtSonguoi.Location = new System.Drawing.Point(35, 191);
            this.txtSonguoi.Name = "txtSonguoi";
            this.txtSonguoi.Size = new System.Drawing.Size(206, 20);
            this.txtSonguoi.TabIndex = 4;
            this.txtSonguoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSonguoi_KeyDown);
            this.txtSonguoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonguoi_KeyPress);
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 442);
            this.Controls.Add(this.tabctrPhong);
            this.Name = "FormPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.tabctrPhong.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            this.tabLoaiphong.ResumeLayout(false);
            this.tabLoaiphong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ListView lsvLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tabctrPhong;
        private System.Windows.Forms.TabPage tabLoaiphong;
        private System.Windows.Forms.TextBox txtSonguoi;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ComboBox cmbTenLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lsvPhong;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnQLVT;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Button btnXoaLoaiPhong;


    }
}