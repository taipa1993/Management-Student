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
using System.Linq;

namespace StudentManagementCSharp
{
    public partial class FormNewStudent : Form
    {
        string id, name, address, mobie;
        Province province;
        District district;
        Commune commune;
        List<Province> listProvince;
        List<District> listDistric;
        List<Commune> listCommune;
        int indexStudent;
        int index;

        int year;
        public FormNewStudent()
        {
            Student student = new Student();
            InitializeComponent();
            listProvince = Home.listProvince;
            comboxBoxProvince.DataSource = listProvince;
            comboxBoxProvince.DisplayMember = "name";
            indexStudent = Home.indexStudent;

            if (indexStudent >= 0)
            {
                student = Home.listStudent[indexStudent];
                txtName.Text = student.Name;
                txtYear.Text = student.Year.ToString();
                txtAddress.Text = student.Address;
                comboxBoxProvince.Text = student.Province.ToString();
                comboBoxDistrict.Text = student.Dictrict.ToString();
                comboBoxCommune.Text = student.Commune.ToString();
                txtMobile.Text = student.Mobile;
            }
        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbDistrict = (ComboBox)sender;
            district = (District)cbDistrict.SelectedItem;
            listCommune = Home.listCommune.Where(c => c.District == district).ToList();
            comboBoxCommune.DataSource = listCommune;
            comboBoxCommune.DisplayMember = "name";
        }

        private void comboxBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbProvine = (ComboBox)sender;
            province = (Province)cbProvine.SelectedItem;
            listDistric = Home.listDistrict.Where(d => d.Province == province).ToList();
            comboBoxDistrict.DataSource = listDistric;
            comboBoxDistrict.DisplayMember = "name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = "  ";
            name = txtName.Text.Trim();
            address = txtAddress.Text.Trim();
            province = (Province)comboxBoxProvince.SelectedItem;
            district = (District)comboBoxDistrict.SelectedItem;
            commune = (Commune)comboBoxCommune.SelectedItem;
            mobie = txtMobile.Text.Trim();
            int.TryParse(txtYear.Text.Trim(), out year);
            Student newStudent = new Student(id, name, year, address, province, district, commune, mobie);
            index = Home.listStudent.FindIndex(s => s.Id ==id);
            if(index>= 0)
            {
                MessageBox.Show("id is exist. Please change");
            }

            if (Home.indexStudent >= 0)
            {
                Home.listStudent[Home.indexStudent] = newStudent;
            }
            else
            {
                Home.listStudent.Add(newStudent);
            }
            this.Close();
        }
    }
}
