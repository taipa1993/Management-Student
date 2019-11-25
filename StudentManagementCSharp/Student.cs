using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp
{
    internal class Student
    {
        string id;
        string name;
        int year;
        string address;
        Province province;
        District district;
        Commune commune;
        string mobile;
        public Student()
        {
                
        }
        public Student(string id, string name, int year, string address,
            Province province, District district, Commune commune, string mobile)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.Address = address;
            this.Province = province;
            this.Dictrict = district;
            this.Commune = commune;
            this.Mobile = mobile;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Address { get => address; set => address = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        internal Province Province { get => province; set => province = value; }
        internal District Dictrict { get => district; set => district = value; }
        internal Commune Commune { get => commune; set => commune = value; }
        public string AddressToString()
        {
            return address + ", " +commune.ToString() + ", " + district.ToString();
        }
    }
}
