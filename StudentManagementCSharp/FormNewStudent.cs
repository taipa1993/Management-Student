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
using StudentManagementCSharp.BusinessObject;

namespace StudentManagementCSharp
{
    public partial class FormNewStudent : Form
    {
        string  name, address, mobie;
        Province province;
        District district;
        Commune commune;
        List<Province> listProvince;     
        int indexStudent;
        int year;
        public FormNewStudent()
        {
            this.Text = "New Student";
            Student student = new Student();
            InitializeComponent();
            listProvince = Home.listProvince;
            comboxBoxProvince.DataSource = listProvince;
            comboxBoxProvince.DisplayMember = "name";
            indexStudent = Home.indexStudent;
            
            if (indexStudent >= 0)
            {
                this.Text = "Edit Student ";
                student = Home.listStudent[indexStudent];
                txtName.Text = student.Name;
                txtYear.Text = student.Year.ToString();
                txtAddress.Text = student.Address;
                comboxBoxProvince.Text = student.Province.Name;
                comboBoxDistrict.Text = student.District.Name;
                comboBoxCommune.Text = student.Commune.Name;
                txtMobile.Text = student.Mobile;
            }
        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbDistrict = (ComboBox)sender;
            district = (District)cbDistrict.SelectedItem;
            district = province.Districts.First(d => d == district);
            comboBoxCommune.DataSource = district.Communes;
            comboBoxCommune.DisplayMember = "name";
        }

        private void comboxBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbProvine = (ComboBox)sender;
            province = (Province)cbProvine.SelectedItem;
            province = listProvince.First(p => p == province);
            comboBoxDistrict.DataSource = province.Districts;
            comboBoxDistrict.DisplayMember = "name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            name = txtName.Text.Trim();
            address = txtAddress.Text.Trim();
            province = (Province)comboxBoxProvince.SelectedItem;
            district = (District)comboBoxDistrict.SelectedItem;
            commune = (Commune)comboBoxCommune.SelectedItem;
            mobie = txtMobile.Text.Trim();
            int.TryParse(txtYear.Text.Trim(), out year);
            Student newStudent = new Student( name, year, address, province, district, commune, mobie);            

            if (Home.indexStudent >= 0)
            {
                Home.listStudent[Home.indexStudent] = newStudent;
                MessageBox.Show("Updated success");
            }
            else
            {
                Home.listStudent.Add(newStudent);
            }
            this.Close();
        }
    }
}
