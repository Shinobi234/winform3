using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
	internal class DocDSSV
	{
		public static class StudentFileHandler
		{
			private static string filePath = "sinhvien.txt";  // Đường dẫn tới file lưu trữ

			// Ghi danh sách sinh viên vào file
			public static void SaveToFile(List<SinhVien> students)
			{
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					foreach (SinhVien student in students)
					{
						writer.WriteLine(student.ToString());
					}
				}
			}

			// Đọc danh sách sinh viên từ file
			public static List<SinhVien> LoadFromFile()
			{
				List<SinhVien> students = new List<SinhVien>();

				if (!File.Exists(filePath))
					return students;

				using (StreamReader reader = new StreamReader(filePath))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						string[] data = line.Split(',');

						// Đảm bảo dữ liệu có đủ 9 trường
						if (data.Length == 9)
						{
							SinhVien student = new SinhVien(
								data[0], // MSSV
								data[1], // HoTenLot
								data[2], // Ten
								DateTime.Parse(data[3]), // NgaySinh
								data[4], // Lop
								data[5], // CMND
								data[6], // SDT
								data[7], // DiaChi
								data[8]  // MonHoc
							);
							students.Add(student);
						}
					}
				}
				return students;
			}
		}
	}
}

