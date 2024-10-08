using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
namespace _2212449_Ktra_De4
{
    public partial class FormSach : Form
    {
        QuanLySach qls;
        public FormSach()
        {
            InitializeComponent();
        }
        #region 
        private Sach GetSach()
        {
            Sach s = new Sach();
            s.MaSach = this.txtMaSach.Text;
            s.TenSach = this.txtTenSach.Text;
            s.NamXB = this.nudNamXB.Text;
            s.TheLoai = this.cboTLoai.Text;

            return s;
        }
        private Sach GetSachListView(ListViewItem lvitem)
        {
            Sach s = new Sach();
            s.MaSach = lvitem.SubItems[0].Text;
            s.TenSach = lvitem.SubItems[1].Text;
            s.NamXB = lvitem.SubItems[2].Text;
            s.TheLoai = lvitem.SubItems[3].Text;
            return s;
        }
        private void ThietLapThongTin(Sach s)
        {
            this.txtMaSach.Text = s.MaSach;
            this.txtTenSach.Text = s.TenSach;
            this.nudNamXB.Text = s.NamXB;
            this.cboTLoai.Text = s.TheLoai;
        }
        private void ThemSach(Sach s)
        {
            ListViewItem lvitem = new ListViewItem(s.MaSach);
            lvitem.SubItems.Add(s.TenSach);
            lvitem.SubItems.Add(s.NamXB);
            lvitem.SubItems.Add(s.TheLoai);
            this.lvDanhSach.Items.Add(lvitem);

        }
        private void LoadListView()
        {
            this.lvDanhSach.Items.Clear();
            foreach (Sach s in qls.DanhSanh)
            {
                ThemSach(s);
            }
        }

        #endregion

        #region
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            Sach s = obj2 as Sach;
            return s.MaSach.CompareTo(obj1);

        }
        private void LoadFromSach(object sender, EventArgs e)
        {
            qls = new QuanLySach();
            LoadListView();
        }
        private void ListViewSach(object sender, EventArgs e)
        {
            int count = this.lvDanhSach.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDanhSach.SelectedItems[0];
                Sach s = GetSachListView(lvitem);
                ThietLapThongTin(s);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtMaSach.Text = "";
            this.txtTenSach.Text = "";
            this.nudNamXB.Text = "";
            this.cboTLoai.Text = this.cboTLoai.Items[0].ToString();

        }
       
        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Sach s = GetSach();
            Sach kq = qls.Tim(s.MaSach,
                delegate (object obj1, object obj2)
            {
                return (obj2 as Sach).MaSach.CompareTo(obj1.ToString());
            });
            if (kq == null)
                MessageBox.Show("Da ton tai ma sach nay!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qls.Them(s);
                this.LoadListView();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private List<SachInfo> LoadJSON(string Path)
        {
            List<SachInfo> List = new List<SachInfo>();     
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd();    
            var array = (JObject)JsonConvert.DeserializeObject(json);
            var students = array["sinhvien"].Children();
            foreach (var item in students) 
            {
                string MaSach = item["MSSV"].Value<string>();
                string TenSach = item["hoten"].Value<string>();
                int NamXB = item["tuoi"].Value<int>();
                int Theloai = item["diem"].Value<int>();
                SachInfo info = new SachInfo(MaSach, TenSach, NamXB, Theloai);
                List.Add(info);
            }
            return List;
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            string Str = ""; 
            string Path = "Z:\\2212449_Ktra_De4\\2212449_Ktra_De4\\sach.json";
            List<SachInfo> List = LoadJSON(Path); 
            for (int i = 0; i < List.Count; i++) 
            {
                SachInfo info = List[i];
                Str += string.Format("Sach {0} có MaSach: {1}, TenSach: {2},  NamXB {3}, TheLoai {4}\r\n"
              , (i + 1), info.MaSach, info.TenSach, info.NamXB, info.TheLoai);
            }
            MessageBox.Show(Str);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
