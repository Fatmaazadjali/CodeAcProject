using CodeAcademyBLL.Interfaces;
using CodeAcademyDAL.Context;
using CodeAcademyDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyBLL.Repsatory
{
    public class DepartmentRebosatory : GenaricReposatory<Department>, IDepartment
    {
        public DepartmentRebosatory(ApplicationDbContext context) : base (context) {

           
        }
    }
}
