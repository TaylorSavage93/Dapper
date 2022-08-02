using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BESTYBUYPRACTICES
{
    internal interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();

        void InsertDepartment(string newDepartmentName);

    }
}
