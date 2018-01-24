using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToCollections
{
    class DataAccessComponent
    {
        public static List<Employee> GetEmps()
        {
            return new List<Employee>
            {
                new Employee {Ecode=101,Ename="Ravi",Salary=1111,Deptid=201},
                new Employee {Ecode=102,Ename="Raman",Salary=2222,Deptid=202},
                new Employee {Ecode=103,Ename="Ramesh",Salary=3333,Deptid=202},
                new Employee {Ecode=104,Ename="Rahul",Salary=4444,Deptid=203},
                new Employee {Ecode=105,Ename="Rohit",Salary=5555,Deptid=201}
            };
        }
        public static List<Department> GetDeparments()
        {
            return new List<Department>
            {
                new Department{Deptid=201,Dname="Account",Dhead=108},
                new Department{Deptid=202,Dname="Admin",Dhead=109},
                new Department{Deptid=203,Dname="Sales",Dhead=107}
            };
        }
    }
}
