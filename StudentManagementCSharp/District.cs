using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp
{
    class District
    {
        int id;
        string name;
        Province province;

        public District(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public District(int id, string name, Province province)
        {
            this.Id = id;
            this.Name = name;
            this.Province = province;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Province Province { get => province; set => province = value; }
        public override string ToString()
        {
            return name;
        }
    }
}
