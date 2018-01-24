using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLibrary
{
    class DataAccessComponent
    {

        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {

                new Employee{Ecode=101, Ename="A", Salary=200, Deptid = 50 },
                new Employee{Ecode=102, Ename="B", Salary=201, Deptid = 51 },
                new Employee{Ecode=103, Ename="C", Salary=202, Deptid = 52 },

                new Employee{Ecode=104, Ename="D", Salary=2033, Deptid = 50 },
                new Employee{Ecode=105, Ename="E", Salary=2033, Deptid = 51 },
                new Employee{Ecode=106, Ename="F", Salary=201, Deptid = 50 },


            };




}

    }
}
