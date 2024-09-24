using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace lab5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xml();
        }
        private List<StudentInfo> LoadJSON(string Path)
        {
            // Khai báo danh sách lưu trữ
            List<StudentInfo> List = new List<StudentInfo>();
            // Đối tượng đọc tập tin 
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd(); // Đọc hết 
                                         // Chuyển về thành mảng các đối tượng
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // Lấy đối tượng sinhvien
            var students = array["sinhvien"].Children();
            foreach (var item in students) // Duyệt mảng
            {
                // Lấy các thành phần 
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();
                // Chuyển vào đối tượng StudentInfo 
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                List.Add(info);// Thêm vào danh sách
            }
            return List;
        }
        private void btnnut_Click(object sender, EventArgs e)
        {
            string Str = ""; // chuỗi lưu trữ
            string Path = "C:\\Users\\PC602\\Downloads\\lab5\\lab5\\json1.json"; // Đường dẫn tập tin
            List<StudentInfo> List = LoadJSON(Path); // Gọi phương thức
            for (int i = 0; i < List.Count; i++) // Đọc danh sách 
            {
                StudentInfo info = List[i];
                Str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2}, điểm TB: {3}\r\n\"" , (i + 1), info.MSSV, info.Hoten, info.Diem);
            }
            MessageBox.Show(Str);
        }


        private void btnXML_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   

        }
        void xml()
        {
            // Load XML file into XmlDocument instance
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\PC602\\Downloads\\lab5\\lab5\\books.xml");
            // Get list of nodes whose name is Book
            var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/books");
            foreach (XmlNode node in nodeList)
            {
                // Read attribute value
                var isbn = node.Attributes["ISBN"].Value;
                // Read child node value
                var title = node.SelectSingleNode("title").InnerText;
                var price = node.SelectSingleNode("price").InnerText;
                // Read the descendant node value
                var firstName = node.SelectSingleNode("author/first-name").InnerText;
                var lastName = node.SelectSingleNode("author/last-name").InnerText;
                Console.WriteLine("{0,-15}{1,-50}{2,-15}{3,-15}{4,6}",
                isbn, title, firstName, lastName, price);
            }
        }
    }

}
