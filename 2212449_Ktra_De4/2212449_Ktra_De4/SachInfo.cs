using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212449_Ktra_De4
{
    internal class SachInfo
    {
        
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int NamXB { get; set; }
        public int TheLoai { get; set; }
       
       
        public SachInfo(string ms, string ts, int nxb, int tl)

        {
            this.MaSach = ms;
            this.TenSach = ts;
            this.NamXB = nxb;
            this.TheLoai = tl;
            
        }
    }
}
