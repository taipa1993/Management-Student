using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp
{
    class Commune
    {
        int id;
        string name;
        District district;

        public Commune(int id, string name, District district)
        {
            this.Id = id;
            this.Name = name;
            this.District = district;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal District District { get => district; set => district = value; }
        public override string ToString()
        {
            return name;
        }
    }
}
