using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the DataSources
            var lstEmp = DataAccessComponent.GetEmps();
            var lstDept = DataAccessComponent.GetDeparments();


            //1. select all employees
            var result = from emp in lstEmp
                         select emp;
            //Extension method syntax
            result = lstEmp.Select(o => o);


            //2. select employee for deptid=202
            var result2 = from emp in lstEmp
                          where emp.Deptid == 202
                          select emp;
            //Extension method syntax
            result2 = lstEmp.Where(o => o.Deptid == 202);


            //3. selecting only few columns
            var result3 = from emp in lstEmp
                          select new
                          {
                              emp.Ecode,
                              emp.Ename,
                              emp.Salary
                          };
            //Extension method
            result3 = lstEmp.Select(o => new
                                    {
                                        o.Ecode,
                                        o.Ename,
                                        o.Salary
                                    });


            //4. select computed column
            var result4 = from emp in lstEmp
                          select new
                          {
                              emp.Ecode,
                              emp.Ename,
                              emp.Salary,
                              emp.Deptid,
                              Bonus=emp.Salary*0.1
                          };
            //Extension method
            result4 = lstEmp.Select(o => new
                                    {
                                        o.Ecode,
                                        o.Ename,
                                        o.Salary,
                                        o.Deptid,
                                        Bonus=o.Salary*0.1
                                    });

            //5. ordering the records
            var result5 = from emp in lstEmp
                          orderby emp.Salary descending
                          select emp;

            //Extension method
            var res = lstEmp.OrderByDescending(emp => emp.Salary);


            //6. Grouping of records
            var result6 = from emp in lstEmp
                          group emp by emp.Deptid into g
                          select new
                          {
                              Deptid=g.Key,
                              TotalSal=g.Sum(emp=>emp.Salary),
                              AvgSal=g.Average(emp=>(emp.Salary==null?0:emp.Salary)),
                              MaxSal=g.Max(emp=>emp.Salary),
                              MinSal=g.Min(emp=>emp.Salary),
                              NoOfEmps=g.Count()                              
                          };

            //display
            foreach (var item in result6)
            {
                Console.WriteLine(item.Deptid+"\t"+item.AvgSal+"\t"+item.MaxSal+"\t"+item.MinSal+"\t"+item.NoOfEmps+"\t"+item.TotalSal); 
            }

            ////display
            //foreach (var item in result5)
            //{
            //    Console.WriteLine(item.Ecode+"\t"+item.Ename+"\t"+item.Salary+"\t"+item.Deptid);//+"\t"+item.Bonus);
            //}

            //joins
            var joinRes = from emp in lstEmp
                          join dep in lstDept
                          on emp.Deptid equals dep.Deptid
                          select new
                          {
                              emp.Ecode,
                              emp.Ename,
                              emp.Salary,
                              emp.Deptid,
                              dep.Dname,
                              dep.Dhead
                          };
            
            //Extension method
            joinRes = lstEmp.Join(lstDept, 
                                  o => o.Deptid, 
                                  i => i.Deptid, 
                                  (o, i) => new 
                                            {
                                                o.Ecode,
                                                o.Ename,
                                                o.Salary,
                                                o.Deptid,
                                                i.Dname,
                                                i.Dhead
                                            });




            //display
            foreach (var item in joinRes)
            {
                Console.WriteLine(item);
            }

        }
    }
}

