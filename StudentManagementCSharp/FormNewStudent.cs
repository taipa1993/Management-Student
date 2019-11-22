using StudentManagementCSharp;
using System;
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
    public partial class FormNewStudent : Form
    {
        string name,address, province, district, commune, mobie;
        int year;
        public FormNewStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if(indexNow)
            name = txtName.Text.Trim();
            address = txtAddress.Text.Trim(); 
            province = txtProvince.Text.Trim();
            district = txtDistric.Text.Trim();
            commune = txtCommune.Text.Trim();
            mobie = txtMobile.Text.Trim();
            int.TryParse(txtYear.Text.Trim(), out year);
            Home.listStudent.Add(new Student(name, year, address,province,district,commune,mobie));
            
            this.Close();
        }
    }
}
