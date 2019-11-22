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
        internal static  List<Student> listStudent;
        public static int indexNow = -1;
        string search = "";
        int index;
        public Home()
        {
            listStudent = new List<Student>();
            listStudent.Add(new Student("tai", 1993, "", "", "", "", ""));
            listStudent.Add(new Student("Nhan", 1994, "", "", "", "", ""));
            listStudent.Add(new Student("Trung", 1992, "", "", "", "", ""));
            listStudent.Add(new Student("Hieu", 1992, "", "", "", "", ""));


            InitializeComponent();
            ShowStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text.Trim();
            List<Student> listSearch = listStudent.Where(s => s.Name.Contains(search)).ToList();
            ShowStudent(listSearch);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newForm = new FormNewStudent();
            newForm.ShowDialog();
            ShowStudent();
        }
        internal void ShowStudent()
        {
            lViewStudent.Items.Clear();
            fLPanelButton.Controls.Clear();
            index = 0;
            foreach(Student item in listStudent)
            {
                index++;
                
                Button btnEdit = new Button() { Name = "btnEdit" 
                    + item.Name.ToString().Trim(),Text ="Edit"};
                btnEdit.Click += BtnEdit_Click;
               
                Button btnDelete = new Button() { Name = "btnEdit"
                    + item.Name.ToString().Trim(), Text = "Delete" };
                btnDelete.Click += BtnDelete_Click;
                fLPanelButton.Controls.Add(btnEdit);
                fLPanelButton.Controls.Add(btnDelete);
                ListViewItem lViewItem = new ListViewItem(index.ToString());
                lViewItem.SubItems.Add(item.Name.ToString());
                lViewItem.SubItems.Add(item.Year.ToString().Trim());
                lViewItem.SubItems.Add(item.FullAddress().Trim());
                lViewItem.SubItems.Add(item.Mobile.ToString().Trim());
                lViewStudent.Items.Add(lViewItem);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btnSelect = (Button)sender;
            string nameSlect = btnSelect.Name.ToString().Trim().Substring(7);           
            index = listStudent.FindIndex(s => s.Name == nameSlect);
            listStudent.RemoveAt(index);
            ShowStudent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button btnSelect = (Button)sender;
            string nameSlect = btnSelect.Name.ToString().Trim().Substring(7);
            indexNow = listStudent.FindIndex(s => s.Name == nameSlect);
            var newForm = new FormNewStudent();
            newForm.ShowDialog();
            ShowStudent();
        }

        internal void ShowStudent(List<Student> listShow)
        {
            lViewStudent.Items.Clear();
            fLPanelButton.Controls.Clear();
            index = 0;
            foreach (Student item in listShow)
            {
                index++;
                Button btnEdit = new Button() { Name = "btnEdit" 
                    + item.Name.ToString().Trim(),Text ="Edit"};
                Button btnDelete = new Button() { Name = "btnEdit"
                    + item.Name.ToString().Trim(), Text = "Delete" };
                fLPanelButton.Controls.Add(btnEdit);
                fLPanelButton.Controls.Add(btnDelete);

                ListViewItem lViewItem = new ListViewItem(index.ToString());
                //Button btnEdit = new Button() { Name = "btn" + item.Name.ToString().Trim(),Text ="Edit"};
                lViewItem.SubItems.Add(item.Name.ToString().Trim());
                lViewItem.SubItems.Add(item.Year.ToString().Trim());
                lViewItem.SubItems.Add(item.FullAddress().Trim());
                lViewItem.SubItems.Add(item.Mobile.ToString().Trim());
                lViewStudent.Items.Add(lViewItem);
            }
        }

        private void btnSoftByName_Click(object sender, EventArgs e)
        {
            listStudent = listStudent.OrderBy(s => s.Name).ToList();
            ShowStudent();
        }
        

        private void btnSoftByYear_Click(object sender, EventArgs e)
        {
            listStudent.Sort(CompareStudent.ComparisonByYear);
            ShowStudent();
        }

        
    }
    
}
