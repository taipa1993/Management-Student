using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp
{
    internal class Student
    {
        string name;
        int year;
        string address;
        string province;
        string dictrict;
        string commune;
        string mobile;

        public Student(string name, int year, string address,
            string province, string dictrict, string commune, string mobile)
        {
            this.Name = name;
            this.Year = year;
            this.Address = address;
            this.Province = province;
            this.Dictrict = dictrict;
            this.Commune = commune;
            this.Mobile = mobile;
        }

        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Address { get => address; set => address = value; }
        public string Province { get => province; set => province = value; }
        public string Dictrict { get => dictrict; set => dictrict = value; }
        public string Commune { get => commune; set => commune = value; }
        public string Mobile { get => mobile; set => mobile = value; }

        public string FullAddress()
        {
            return address + ", " + commune + ", " + dictrict + ", " + province;
        }
    }
}
