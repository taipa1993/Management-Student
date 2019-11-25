using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentManagementCSharp
{
    public partial class Home : Form
    {
        internal static  List<Student> listStudent = new List<Student>();
        internal static List<Province> listProvince = new List<Province>();
        internal static List<District> listDistrict = new List<District>(); 
        internal static List<Commune> listCommune = new List<Commune>();
        List<Student> showList = new List<Student>();

        internal static int indexStudent = -1;
        public Home()
        {
            
            
            Load();
            InitializeComponent();
            showList = listStudent;
            ShowStudent(listStudent);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();
            List<Student> listSearch = listStudent.Where(s => s.Name.ToLower().Contains(search)).ToList();
            ShowStudent(listSearch);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            indexStudent = -1;
            var newForm = new FormNewStudent();
            newForm.ShowDialog();
            ShowStudent(listStudent);
        }
        
        internal void ShowStudent(List<Student> listShow)
        {
            dGView.Rows.Clear();
            int value = 0;
            foreach(Student item in listShow)
            {
                string noValue = (value++).ToString();
                string[] row = new string[] {noValue,item.Id,item.Name,item.Year.ToString(),
                    item.AddressToString(),item.Mobile,"Edit","Delete" };
                
                dGView.Rows.Add(row);
            }
        }

        
        private void btnSoftByName_Click(object sender, EventArgs e)
        {
            listStudent = listStudent.OrderBy(s => s.Name).ToList();
            ShowStudent(listStudent);
        }
        

        private void btnSoftByYear_Click(object sender, EventArgs e)
        {
            listStudent.Sort(CompareStudent.ComparisonByYear);
            ShowStudent(listStudent);
        }

        private void dGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {               
                string id = dGView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                indexStudent = listStudent.FindIndex(s => s.Id == id);
                DialogResult result = MessageBox.Show("Are you sure to delete ?", "Caption", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    listStudent.RemoveAt(indexStudent);
                    ShowStudent(listStudent);
                }
            }else if(e.ColumnIndex == 6)
            {
                indexStudent = 0;

                string id = dGView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                indexStudent = listStudent.FindIndex(s => s.Id == id);
                var newForm = new FormNewStudent();
                newForm.ShowDialog();
                ShowStudent(listStudent);
            }
        }
        private void Load()
        {
            Province TPhanoi = new Province(1, "Tp Ha Noi");
            Province TPHoChiMinh = new Province(2, "Tp Ho Chi Minh");
            Province NamDinh = new Province(3, "Tinh Nam Dinh");

            listProvince.Add(TPhanoi);
            listProvince.Add(TPHoChiMinh);
            listProvince.Add(NamDinh);

            District QBaDinh = new District(11, "Quan Ba Dinh", TPhanoi);
            District QHoanKiem = new District(12, "Quan Hoan Kiem", TPhanoi);
            District HThanhTri = new District(13, "Huyen Thanh Tri", TPhanoi);

            listDistrict.Add(QBaDinh);
            listDistrict.Add(QHoanKiem);
            listDistrict.Add(HThanhTri);

            District Quan1 = new District(21, "Quan 1", TPHoChiMinh);
            District Quan4 = new District(22, " Quan 4", TPHoChiMinh);
            District Quan5 = new District(23, "Quan 5", TPHoChiMinh);
            listDistrict.Add(Quan1);
            listDistrict.Add(Quan4);
            listDistrict.Add(Quan5);

            District TPNamDinh = new District(31, "TP Nam Dinh", NamDinh);
            District HHaiHau = new District(32, "Huyen Hai Hau", NamDinh);
            District HXuanTruong = new District(33, "Huyen Xuan Truong", NamDinh);

            listDistrict.Add(TPNamDinh);
            listDistrict.Add(HHaiHau);
            listDistrict.Add(HXuanTruong);

            listCommune.Add(new Commune(111, "Phuong Giang Vo", QBaDinh));
            listCommune.Add(new Commune(112, "Phuong Lieu Giai", QBaDinh));
            listCommune.Add(new Commune(113, "Phuong Kim Ma", QBaDinh));

            listCommune.Add(new Commune(121, "Phuong Hang Dao", QHoanKiem));
            listCommune.Add(new Commune(122, "Phuong Hang Ma", QHoanKiem));
            listCommune.Add(new Commune(123, "Phuong Trang Tien", QHoanKiem));

            listCommune.Add(new Commune(131, "Phuong Ngoc Hoi", HThanhTri));
            listCommune.Add(new Commune(132, "Phuong Tam Hiep", HThanhTri));
            listCommune.Add(new Commune(133, "Phuong Tu Hiep", HThanhTri));

            listCommune.Add(new Commune(211, "Phuong Tan Dinh", Quan1));
            listCommune.Add(new Commune(212, "Phuong Ben Thanh", Quan1));
            listCommune.Add(new Commune(213, "Phuong Pham Ngu Lao", Quan1));

            listCommune.Add(new Commune(221, "Phuong 1", Quan4));
            listCommune.Add(new Commune(221, "Phuong 2", Quan4));
            listCommune.Add(new Commune(221, "Phuong 3", Quan4));

            listCommune.Add(new Commune(231, "Phuong 1", Quan5));
            listCommune.Add(new Commune(232, "Phuong 2", Quan5));
            listCommune.Add(new Commune(233, "Phuong 3", Quan5));

            listCommune.Add(new Commune(311, "Phuong Nguyen Du", TPNamDinh));
            listCommune.Add(new Commune(312, "Phuong Tran Hung Dao", TPNamDinh));
            listCommune.Add(new Commune(313, "Phuong Cua Bac", TPNamDinh));

            listCommune.Add(new Commune(321, "Xa Hai Anh", HHaiHau));
            listCommune.Add(new Commune(322, "Xa Hai Thinh", HHaiHau));
            listCommune.Add(new Commune(323, "Xa Hai Son", HHaiHau));

            listCommune.Add(new Commune(331, "Xa Xuan Phong", HXuanTruong));
            listCommune.Add(new Commune(332, "Xa Xuan Thuy", HXuanTruong));
            listCommune.Add(new Commune(333, "Xa Xuan Ninh", HXuanTruong));

            Student nhan = new Student("002", "nhan", 1994, "to dan pho so 3 ",
                TPhanoi, QBaDinh, listCommune[0], "0123456789");
            listStudent.Add(nhan);

            Student nam = new Student("003", "nam", 1995, "113",
                listProvince[0], listDistrict[0], listCommune[0], "0123456789");
            listStudent.Add(nam);

        }
        
    }
    
}
