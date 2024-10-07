using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
	public partial class Form1 : Form
	{
		QuanLySV qlsv;
		public Form1()
		{
			InitializeComponent();
		}
		#region z
		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();

			// Gán các thuộc tính cho sinh viên dựa trên các giá trị trong form
			sv.MSSV = this.txtMSSV.Text; // MSSV
			sv.HoTenLot = this.txtHoTenLot.Text; // Họ tên lót
			sv.Ten = this.txtTen.Text; // Tên
			sv.NgaySinh = this.dtpNgaySinh.Value; // Ngày sinh
			sv.Lop = this.txtLop.Text; // Lớp
			sv.CMND = this.txtCMND.Text; // CMND
			sv.SDT = this.txtSDT.Text; // Số điện thoại
			sv.DiaChi = this.txtDiaChi.Text; // Địa chỉ
			sv.MonHoc = this.chkMonHoc.Text; // Môn học đăng ký

			return sv;
		}
		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();

			// Gán các thuộc tính dựa trên các cột trong ListViewItem
			sv.MSSV = lvitem.SubItems[0].Text; // Mã số sinh viên (MSSV)
			sv.HoTenLot = lvitem.SubItems[1].Text; // Họ tên lót
			sv.Ten = lvitem.SubItems[2].Text; // Tên
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text); // Ngày sinh
			sv.Lop = lvitem.SubItems[4].Text; // Lớp
			sv.CMND = lvitem.SubItems[5].Text; // CMND
			sv.SDT = lvitem.SubItems[6].Text; // Số điện thoại (SDT)
			sv.DiaChi = lvitem.SubItems[7].Text; // Địa chỉ
			sv.MonHoc = lvitem.SubItems[8].Text; // Môn học đăng ký

			return sv;
		}
		private void ThietLapThongTin(SinhVien sv)
		{
			// Gán giá trị cho các ô điều khiển tương ứng với các thuộc tính của SinhVien
			this.txtMSSV.Text = sv.MSSV; // Mã số sinh viên (MSSV)
			this.txtHoTenLot.Text = sv.HoTenLot; // Họ tên lót
			this.txtTen.Text = sv.Ten; // Tên
			this.dtpNgaySinh.Value = sv.NgaySinh; // Ngày sinh
			this.txtLop.Text = sv.Lop; // Lớp
			this.txtCMND.Text = sv.CMND; // CMND
			this.txtSDT.Text = sv.SDT; // Số điện thoại (SDT)
			this.txtDiaChi.Text = sv.DiaChi; // Địa chỉ
											 // Gán giá trị cho môn học
			this.chkMonHoc.Text = sv.MonHoc; // Gán môn học vào điều khiển tương ứng

			// Kiểm tra và đánh dấu môn học trong danh sách (nếu cần)
			string[] monHocs = sv.MonHoc.Split(','); // Giả sử các môn học được phân tách bằng dấu phẩy
			for (int i = 0; i < this.chkMonHoc.Items.Count; i++) // Giả sử có clbMonHoc để kiểm tra các môn học
			{
				// Đặt lại trạng thái cho tất cả các mục
				this.chkMonHoc.SetItemChecked(i, false);

				// Kiểm tra từng môn học trong danh sách đã gán
				foreach (string mon in monHocs)
				{
					// So sánh và đánh dấu môn học tương ứng
					if (mon.Trim().CompareTo(this.chkMonHoc.Items[i].ToString()) == 0)
					{
						this.chkMonHoc.SetItemChecked(i, true); // Đánh dấu môn học được kiểm tra
						break; // Thoát vòng lặp vì đã tìm thấy môn học
					}
				}
			}
		}
		// Thêm sinh viên vào ListView
		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MSSV); // Sử dụng MSSV thay vì MaSo
			lvitem.SubItems.Add(sv.HoTenLot + " " + sv.Ten); // Kết hợp họ tên lót và tên
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString()); // Ngày sinh
			lvitem.SubItems.Add(sv.DiaChi); // Địa chỉ
			lvitem.SubItems.Add(sv.Lop); // Lớp
			lvitem.SubItems.Add(sv.CMND); // CMND
			lvitem.SubItems.Add(sv.SDT); // Số điện thoại

			// Giả sử bạn chỉ có một môn học trong thuộc tính MonHoc
			lvitem.SubItems.Add(sv.MonHoc); // Môn học

			this.lvSinhVien.Items.Add(lvitem); // Thêm item vào ListView
		}

		// Hiển thị các sinh viên trong qlsv lên ListView
		private void LoadListView()
		{
			this.lvSinhVien.Items.Clear(); // Xóa các item cũ trong ListView
			foreach (SinhVien sv in qlsv.DanhSach)
			{
				ThemSV(sv); // Gọi phương thức thêm sinh viên
			}
		}


		#endregion
		#region 
		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			// Khởi tạo đối tượng quản lý sinh viên
			qlsv = new QuanLySV();

			// Đọc danh sách sinh viên từ file
			qlsv.DocTuFile();

			// Tải danh sách sinh viên vào ListView
			LoadListView();
		}
		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Kiểm tra có dòng nào được chọn không
			int count = this.lvSinhVien.SelectedItems.Count;
			if (count > 0)
			{
				// Lấy dòng đầu tiên được chọn
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];

				// Lấy thông tin sinh viên từ dòng ListView
				SinhVien sv = GetSinhVienLV(lvitem);

				// Gán thông tin sinh viên lên các control trên form
				ThietLapThongTin(sv);
			}
		}


		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			// Lấy MSSV từ TextBox (giả sử bạn có một TextBox tên là txtMSSV)  
			string mssv = this.txtMSSV.Text.Trim(); // Thay btnTimKiem.Text bằng txtMSSV.Text  

			// Tìm kiếm sinh viên trong danh sách  
			SinhVien foundStudent = qlsv.Tim(mssv, (obj1, svItem) =>
			{
				return svItem.MSSV.CompareTo(obj1 as string);
			});

			// Kiểm tra nếu tìm thấy sinh viên  
			if (foundStudent != null)
			{
				// Gán thông tin sinh viên vào các control để hiển thị  
				ThietLapThongTin(foundStudent);
			}
			else
			{
				// Nếu không tìm thấy, hiển thị thông báo  
				MessageBox.Show("Không tìm thấy sinh viên với MSSV: " + mssv, "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			SinhVien kq = qlsv.Tim(sv.MSSV, delegate (object obj1, object obj2)

			{
				return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());

			});
			if (kq != null)
				MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				this.qlsv.Them(sv);
				this.LoadListView();
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			// Lấy thông tin sinh viên từ các control
			SinhVien sv = GetSinhVien();

			// Tìm sinh viên trong danh sách để cập nhật
			SinhVien existingStudent = qlsv.Tim(sv.MSSV, (obj1, svItem) =>
			{
				return svItem.MSSV.CompareTo(obj1 as string);
			});

			// Kiểm tra xem sinh viên có tồn tại không
			if (existingStudent != null)
			{
				// Cập nhật thông tin
				existingStudent.HoTenLot = sv.HoTenLot;
				existingStudent.Ten = sv.Ten;
				existingStudent.NgaySinh = sv.NgaySinh;
				existingStudent.DiaChi = sv.DiaChi;
				existingStudent.Lop = sv.Lop;
				existingStudent.CMND = sv.CMND;
				existingStudent.SDT = sv.SDT;
				existingStudent.MonHoc = sv.MonHoc;
				existingStudent.GioiTinh = sv.GioiTinh;
				existingStudent.Hinh = sv.Hinh; // Nếu bạn có hình ảnh

				// Cập nhật lại ListView
				LoadListView();
				MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Không tìm thấy sinh viên để cập nhật!", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
	// Chức năng thêm sinh viên


	#endregion
}











