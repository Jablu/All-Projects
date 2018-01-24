using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLibrary;

namespace LinQModule
{
    class Program
    {
       

        static void Main(string[] args)
        {
            var empList = new DataAccessComponent().GetEmployees();
            var deptList = new DataAccessComponent().GetDeptartment();

            //1. Select All Employee
            var result = from emp in empList
                         select emp;

            //Extension Syntax
            result = empList.Select(o => o);


            //2. Select Where Department Id = 52
            var result2 = from emp in empList
                         where emp.Deptid == 52
                         select emp;

            //Extension method syntax
            result2 = empList.Where(o => o.Deptid == 52);


            //3. Select Only Few Columns
            var result3 = from emp in empList
                          select new
                          {
                              emp.Ecode,
                              emp.Ename
                          };
            //Extension Method
            

            


            //4. Select Computed Columns
            var result4 = from emp in empList
                          select new
                          {
                              newCode = emp.Ecode,
                              newName = emp.Ename,
                              newSalary = emp.Salary,
                              newDept = emp.Salary,
                              bonus = emp.Salary * 0.1,
                          };
            //Extension Method
            //result4 = empList.Select (o => new {
            //    o.Ecode,
            //    o.Ename,
            //    o.Salary,
            //    o.Deptid,
            //    bonus = o.Salary * 0.1,
            //});


            //5. Order Records
            var result5 = from emp in empList
                          orderby emp.Salary descending
                          select emp;


            //6. Grouping Records
            var result6 = from emp in empList
                          group emp by emp.Deptid into g
                          select new
                          {
                              did = g.Key,
                          };
            




            //Display
            foreach (var item in result)
            {

                Console.WriteLine(item.Ecode + "\t" + item.Ename + "\t" + item.Deptid + "\t" + item.Salary );

            }
            Console.WriteLine("");

            //Display
            foreach (var item in result2)
            {

                Console.WriteLine(item.Ecode + "\t" + item.Ename + "\t" + item.Deptid + "\t" + item.Salary);

            }
            Console.WriteLine("");

            //Display
            foreach (var item in result3)
            {

                Console.WriteLine(item.Ecode + "\t" + item.Ename + "\t" );

            }
            Console.WriteLine("");

            //Display
            foreach (var item in result4)
            {

                Console.WriteLine(item.newName + "\t" + item.newName + "\t" + item.newDept + "\t" + item.newSalary + "\t" + item.bonus);

            }



            //Joins
            var joinsResult = from emp in empList
                              join dep in deptList 
                              on emp.Deptid equals dep.Deptid
                              select new
                              {

                                  emp.Ecode,
                                  emp.Ename,
                                  emp.Salary,
                                  emp.Deptid,
                                  dep.Dhead,
                                  dep.Dname

                              };
            //Extension Methods
            joinsResult = empList.Join(deptList, o => o.Deptid, i => i.Deptid,
                (o, i) => new
                {
                    o.Ecode,
                    o.Ename,
                    o.Salary,
                    o.Deptid,
                    i.Dhead,
                    i.Dname
                });

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
