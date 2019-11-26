using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementCSharp.BusinessObject;

namespace StudentManagementCSharp
{
    internal class Student
    {
        private static int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Address { get; set; }
        public Province Province { get; set; }
        public District  District { get; set; }
        public Commune Commune { get; set; }
        public string Mobile { get; set; }

        public Student()
        {
            count++;
        }
     
        public Student( string name, int year, string address,
            Province province, District district, Commune commune, string mobie)
        {
            Id = count++;
            Name = name;
            Year = year;
            Address = address;
            Province = province;
            District = district;
            Commune = commune;
            Mobile = mobie;
        }
        public string AddressToString()
        {
            return Address +", "+ Commune.Name + ", " + District.Name + ", " + Province.Name;
        }
    }
}
