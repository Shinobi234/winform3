using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212449_Ktra_De4
{
    internal class QuanLySach
    {
        public delegate int SoSanh(object obj1, object obj2);
        public List<Sach> DanhSanh;
        public QuanLySach()
        {
            DanhSanh = new List<Sach>();
        }
        public void Them(Sach s)
        {
            this.DanhSanh.Add(s);
        }
        public Sach this[int index]
        {
            get { return DanhSanh[index]; }
            set { DanhSanh[index] = value; }
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSanh.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this.DanhSanh[i]) == 0)
                {
                    this.DanhSanh.RemoveAt(i);
                }
        }
        public Sach Tim(object obj, SoSanh ss)
        {
            Sach result = null;
            foreach (Sach s in DanhSanh)
            {
                if (ss(obj, s) == 0)
                {
                    result = s;
                    break;
                }
            }
            return result;
        }
        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt", t;
            string[] s;
            Sach sach;
            StreamReader sr = new StreamReader(
            new FileStream(filename,
           FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sach = new Sach();
                sach.MaSach = s[0];
                sach.TenSach = s[1];
                sach.NamXB = s[2];
                sach.TheLoai = s[3];

                this.Them(sach);
            }

        }
    }
}




