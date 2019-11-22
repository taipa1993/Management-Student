using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCSharp
{
    class CompareStudent
    {
        internal static int ComparisonByYear(Student x, Student y)
        {
            if (x.Year < y.Year)
            {
                return -1;
            }
            else if (x.Year > y.Year)
            {
                return 1;
            }
            else return 0;

        }
        internal static int ComparisonByName(Student x, Student y)
        {
            return String.Compare(x.Name.ToString(), y.Name.ToString());

        }

    }
}
