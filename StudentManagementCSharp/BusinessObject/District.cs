using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp.BusinessObject
{
    class District : BaseMasterData
    {
        public List<Commune> Communes { get; set; }
        public District(int id, string name) : base(id, name)
        {
        }
        public District(int id, string name, List<Commune> communes) : base(id, name)
        {
            Communes = communes;
        }
    }
}
