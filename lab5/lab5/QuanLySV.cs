using lab5;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab5
{
	public delegate int SoSanh(object sv1, object sv2);

	class QuanLySV
	{
		public List<SinhVien> DanhSach;

		public QuanLySV()
		{
			DanhSach = new List<SinhVien>();
		}

		// Thêm một sinh viên vào danh sách
		public void  Them(SinhVien sv)
		{

			this.DanhSach.Add(sv);
			
		}


		// Chỉ mục (indexer) để truy cập sinh viên theo chỉ số
		public SinhVien this[int index]
		{
			get { return DanhSach[index]; }
			set { DanhSach[index] = value; }
		}

		// Xóa các đối tượng trong danh sách nếu thỏa điều kiện so sánh
		public void Xoa(object obj, SoSanh ss)
		{
			for (int i = DanhSach.Count - 1; i >= 0; i--)
			{
				if (ss(obj, this[i]) == 0)
					this.DanhSach.RemoveAt(i);
			}
		}

		// Tìm sinh viên theo điều kiện so sánh
		public SinhVien Tim(object obj, SoSanh ss)
		{
			foreach (SinhVien sv in DanhSach)
			{
				if (ss(obj, sv) == 0)
				{
					return sv;
				}
			}
			return null;
		}

		// Sửa thông tin sinh viên dựa trên điều kiện so sánh
		public bool Sua(SinhVien svsua, object obj, SoSanh ss)
		{
			for (int i = 0; i < DanhSach.Count; i++)
			{
				if (ss(obj, this[i]) == 0)
				{
					this[i] = svsua;
					return true;
				}
			}
			return false;
		}

		// Đọc danh sách sinh viên từ file
		public void DocTuFile()
		{
			string filename = "\"D:\\lab5\\lab5\\bin\\Debug\\SinhVien.txt.txt\"";
			if (!File.Exists(filename))
			{
				Console.WriteLine("File không tồn tại!");
				return;
			}

			using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					string[] s = line.Split('*');
					SinhVien sv = new SinhVien
					{
						MSSV = s[0],
						HoTenLot = s[1],
						Ten = s[2],
						NgaySinh = DateTime.Parse(s[3]),
						Lop = s[4],
						CMND = s[5],
						SDT = s[6],
						DiaChi = s[7],
						MonHoc = s[8]
					};
					this.Them(sv);
				}
			}
		}

		// Ghi danh sách sinh viên ra file
		public void GhiRaFile()
		{
			string filename = "DanhSachSV.txt";
			using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create)))
			{
				foreach (SinhVien sv in DanhSach)
				{
					sw.WriteLine(sv.ToString());
				}
			}
		}
	}
}
