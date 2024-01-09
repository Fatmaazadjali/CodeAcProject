using CodeAcademyDAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyBLL.Repsatory
{
    public class EmployeeRebosatory<T> : GenaricReposatory<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRebosatory(ApplicationDbContext context)

        {
            _context = context;
        }


    }
}
