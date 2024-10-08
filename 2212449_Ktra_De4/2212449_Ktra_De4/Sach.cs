using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212449_Ktra_De4
{
    internal class Sach
    {
        public string MaSach {  get; set; }
        public string TenSach { get; set; }
        public string NamXB { get; set; }
        public string TheLoai {  get; set; }
        public  Sach() { }
        public Sach (string ms, string ten, string NamXB, string tl)
        {
            this.MaSach = ms;
            this.TenSach = ten;
            this.NamXB = NamXB;
            this.TheLoai = tl;
        }
        public override string ToString()
        {
            return $"{MaSach}, {TenSach}, {NamXB}, {TheLoai}";
        }
    }
}
