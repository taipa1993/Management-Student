using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp.BusinessObject
{
    internal class Province : BaseMasterData
    {
        public List<District> Districts { get; set; }

        public Province(int id, string name) : base(id, name)
        {
        }
        public Province(int id, string name, List<District> district) : base(id, name)
        {
            Districts = district;
        }
    }
}
