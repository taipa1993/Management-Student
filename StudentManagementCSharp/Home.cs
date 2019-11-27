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
using StudentManagementCSharp.BusinessObject;


namespace StudentManagementCSharp
{
    public partial class Home : Form
    {
        internal static List<Student> listStudent = new List<Student>();
        internal static List<Province> listProvince = new List<Province>();
        internal static int indexStudent = -1;
        int soft = 0;
        public Home()
        {
            LoadData();
            InitializeComponent();
            //ShowStudent(listStudent);
            ShowList(listStudent);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudent();
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
            foreach (Student item in listShow)
            {
                string noValue = (value++).ToString();
                string[] row = new string[] {noValue,item.Id.ToString(),item.Name,item.Year.ToString(),
                    item.AddressFull,item.Mobile,"Edit","Delete" };
                dGView.Rows.Add(row);
            }
        }

        internal  void ShowList(List<Student> listShow)
        {

            var show = from Student in listShow
                       select new
                       {Student.Id, Student.Name, Student.Year,Student.AddressFull,
                           Student.Mobile,edit = "edit", delete ="delete"
                       };
            dGView.DataSource = show.ToList();
            //dGView.Columns[""]
        }

        private void btnSoftByName_Click(object sender, EventArgs e)
        {
            if(soft == 1)
            {
                listStudent = listStudent.OrderByDescending(s => s.Name).ToList();
                soft = 0;
            }
            else
            {
                listStudent = listStudent.OrderBy(s => s.Name).ToList();
                soft = 1;
            }
            ShowStudent(listStudent);
        }


        private void btnSoftByYear_Click(object sender, EventArgs e)
        {
            if (soft == 1)
            {
                listStudent = listStudent.OrderByDescending(s => s.Year).ToList();
                soft = 0;
            }
            else
            {
                listStudent = listStudent.OrderBy(s => s.Year).ToList();
                soft = 1;
            }
            ShowStudent(listStudent);
        }

        private void dGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex>=0)
            {
                int id;
                int.TryParse(dGView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(), out id);
                if (e.ColumnIndex == 7)
                {

                    indexStudent = listStudent.FindIndex(s => s.Id == id);
                    DialogResult result = MessageBox.Show("Are you sure want to delete this student ?"
                        , "Caption", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        listStudent.RemoveAt(indexStudent);
                        ShowStudent(listStudent);
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    indexStudent = 0;
                    indexStudent = listStudent.FindIndex(s => s.Id == id);
                    var newForm = new FormNewStudent();
                    newForm.ShowDialog();
                    ShowStudent(listStudent);
                }
            }
        }
        private void LoadData()
        {

            PrepareProvinceData();
            PrepareDistrictData();
            PrepareCommune();

            Student nhan = new Student("nhan", 1994, "so 3",listProvince[0],
                listProvince[0].Districts[0],listProvince[0].Districts[0].Communes[0], "0123456789");
            listStudent.Add(nhan);
            Student nam = new Student("nam", 1995, "to dan pho 6", listProvince[1],
                listProvince[1].Districts[1], listProvince[1].Districts[1].Communes[1], "0956545545");
            listStudent.Add(nam);
        }

        private void PrepareProvinceData()
        {
            Province TPhanoi = new Province(1, "Tp Ha Noi");
            Province TPHoChiMinh = new Province(2, "Tp Ho Chi Minh");
            Province NamDinh = new Province(3, "Tinh Nam Dinh");

            listProvince.Add(TPhanoi);
            listProvince.Add(TPHoChiMinh);
            listProvince.Add(NamDinh);
        }
        private void PrepareDistrictData()
        {
            District QBaDinh = new District(11, "Quan Ba Dinh");
            District QHoanKiem = new District(12, "Quan Hoan Kiem");
            District HThanhTri = new District(13, "Huyen Thanh Tri");

            listProvince[0].Districts = new List<District> { QBaDinh, QHoanKiem, HThanhTri };

            District quan1 = new District(21, "Quan 1");
            District quan4 = new District(22, "Quan 4");
            District quan5 = new District(23, "Quan 5");

            listProvince[1].Districts = new List<District> { quan1, quan4, quan5 };

            District tpnamdinh = new District(31, "Tp Nam Dinh");
            District hhaihau = new District(32, "Huyen Hai Hau");
            District hxuantruong = new District(33, "Huyen Xuan Truong");

            listProvince[2].Districts = new List<District> { tpnamdinh, hhaihau, hxuantruong };
        }
        private void PrepareCommune()
        {
            List<Commune> listCommune = new List<Commune>();
            listCommune.Add(new Commune(111, "Phuong Giang Vo"));
            listCommune.Add(new Commune(112, "Phuong Lieu Giai"));
            listCommune.Add(new Commune(113, "Phuong Kim Ma"));

            listCommune.Add(new Commune(121, "Phuong Hang Dao"));
            listCommune.Add(new Commune(122, "Phuong Hang Ma"));
            listCommune.Add(new Commune(123, "Phuong Trang Tien"));

            listCommune.Add(new Commune(131, "Phuong Ngoc Hoi"));
            listCommune.Add(new Commune(132, "Phuong Tam Hiep"));
            listCommune.Add(new Commune(133, "Phuong Tu Hiep"));

            listCommune.Add(new Commune(211, "Phuong Tan Dinh"));
            listCommune.Add(new Commune(212, "Phuong Ben Thanh"));
            listCommune.Add(new Commune(213, "Phuong Pham Ngu Lao"));

            listCommune.Add(new Commune(221, "Phuong 1"));
            listCommune.Add(new Commune(221, "Phuong 2"));
            listCommune.Add(new Commune(221, "Phuong 3"));

            listCommune.Add(new Commune(231, "Phuong 1"));
            listCommune.Add(new Commune(232, "Phuong 2"));
            listCommune.Add(new Commune(233, "Phuong 3"));

            listCommune.Add(new Commune(311, "Phuong Nguyen Du"));
            listCommune.Add(new Commune(312, "Phuong Tran Hung Dao"));
            listCommune.Add(new Commune(313, "Phuong Cua Bac"));

            listCommune.Add(new Commune(321, "Xa Hai Anh"));
            listCommune.Add(new Commune(322, "Xa Hai Thinh"));
            listCommune.Add(new Commune(323, "Xa Hai Son"));

            listCommune.Add(new Commune(331, "Xa Xuan Phong"));
            listCommune.Add(new Commune(332, "Xa Xuan Thuy"));
            listCommune.Add(new Commune(333, "Xa Xuan Ninh"));

            for (int value = 0; value < 9; value++)
            {
                listProvince[value / 3].Districts[value % 3].Communes = listCommune.GetRange(value * 3, 3);
            }
        }

        

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string search = txtSearch.Text.Trim().ToLower();
                List<Student> listSearch = listStudent.Where(s => s.Name.ToLower().Contains(search)).ToList();
                ShowStudent(listSearch);
            }
        }
        private void SearchStudent()
        {
            string search = txtSearch.Text.Trim().ToLower();
            List<Student> listSearch = listStudent.Where(s => s.Name.ToLower().Contains(search)).ToList();
            ShowStudent(listSearch);
        }
    }

}
