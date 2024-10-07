using System.Drawing;
using System.Windows.Forms;

namespace lab5
{
	partial class Form1
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
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, null);
			this.label1 = new System.Windows.Forms.Label();
			this.txtMSSV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHoTenLot = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLop = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCMND = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.chkMonHoc = new System.Windows.Forms.CheckedListBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnThemMoi = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV ";
			// 
			// txtMSSV
			// 
			this.txtMSSV.Location = new System.Drawing.Point(63, 12);
			this.txtMSSV.Name = "txtMSSV";
			this.txtMSSV.Size = new System.Drawing.Size(100, 22);
			this.txtMSSV.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Họ và tên lót :";
			// 
			// txtHoTenLot
			// 
			this.txtHoTenLot.Location = new System.Drawing.Point(103, 38);
			this.txtHoTenLot.Name = "txtHoTenLot";
			this.txtHoTenLot.Size = new System.Drawing.Size(100, 22);
			this.txtHoTenLot.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên :";
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(48, 64);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(100, 22);
			this.txtTen.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ngày sinh :";
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(79, 90);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(100, 22);
			this.dtpNgaySinh.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Lớp :";
			// 
			// txtLop
			// 
			this.txtLop.Location = new System.Drawing.Point(52, 116);
			this.txtLop.Name = "txtLop";
			this.txtLop.Size = new System.Drawing.Size(100, 22);
			this.txtLop.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "SĐT :";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(59, 142);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(100, 22);
			this.txtSDT.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Số CMND :";
			// 
			// txtCMND
			// 
			this.txtCMND.Location = new System.Drawing.Point(66, 168);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(100, 22);
			this.txtCMND.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 197);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Địa chỉ liên lạc :";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(103, 194);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
			this.txtDiaChi.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 223);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Môn học đăng ký :";
			// 
			// chkMonHoc
			// 
			this.chkMonHoc.FormattingEnabled = true;
			this.chkMonHoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình thiết bị di động",
            "An toàn và bảo mật hệ thống"});
			this.chkMonHoc.Location = new System.Drawing.Point(15, 239);
			this.chkMonHoc.Name = "chkMonHoc";
			this.chkMonHoc.Size = new System.Drawing.Size(200, 55);
			this.chkMonHoc.TabIndex = 17;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(15, 309);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 18;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Location = new System.Drawing.Point(96, 309);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
			this.btnThemMoi.TabIndex = 19;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(177, 309);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 20;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(258, 309);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 21;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2});
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
			this.lvSinhVien.Location = new System.Drawing.Point(15, 338);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(607, 162);
			this.lvSinhVien.TabIndex = 24;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(634, 501);
			this.Controls.Add(this.lvSinhVien);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnThemMoi);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.chkMonHoc);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtCMND);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtSDT);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLop);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtHoTenLot);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMSSV);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Nhập thông tin sinh viên";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion


		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMSSV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHoTenLot;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLop;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCMND;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckedListBox chkMonHoc;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Button btnThemMoi;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnThoat;
		private ListView lvSinhVien;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
	}
}


