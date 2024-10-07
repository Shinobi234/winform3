using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
	public class SinhVien
	{
		public string MSSV { get; set; }
		public string HoTenLot { get; set; }
		public string Ten { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public string CMND { get; set; }
		public string SDT { get; set; }
		public string DiaChi { get; set; }
		public string MonHoc { get; set; }
		public string Hinh { get; set; }
		public bool GioiTinh { get; set; } // true nếu Nam, false nếu Nữ

		// Constructor không tham số
		public SinhVien() { }

		// Constructor có tham số
		public SinhVien(string mssv, string hoTenLot, string ten, DateTime ngaySinh, string lop, string cmnd, string sdt, string diaChi, string monHoc, string hinh)
		{
			MSSV = mssv;
			HoTenLot = hoTenLot;
			Ten = ten;
			NgaySinh = ngaySinh;
			Lop = lop;
			CMND = cmnd;
			SDT = sdt;
			DiaChi = diaChi;
			MonHoc = monHoc;
			Hinh = hinh;
		}

		public SinhVien(string v1, string v2, string v3, DateTime dateTime, string v4, string v5, string v6, string v7, string v8)
		{
		}
	}






}
