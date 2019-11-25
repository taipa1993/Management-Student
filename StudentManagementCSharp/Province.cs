using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp
{
    class Province
    {
        int id;
        string name;

        public Province(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public override string ToString()
        {
            return name;
        }
    }
}
