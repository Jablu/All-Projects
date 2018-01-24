using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLib;

namespace LinqToSQLDemo
{
    class Program
    {
        static void Main(string[] args)
        {   
            //get all the employees
            ITCDBDataContext ctx = new ITCDBDataContext();
            var result = from emp in ctx.tbl_employees
                        select emp;


            //InsertMethod(ctx);

            //DeleteMethod(ctx);

            //UpdateMethod(ctx);

            ctx.sp_UpdateSalaryByEcode(420, 4646);
            Console.WriteLine("Procedure called");

            //display
            foreach (var item in result)
            {
                Console.WriteLine(item.ecode+"\t"+item.ename+"\t"+item.salary+"\t"+item.deptid);
            }

        }

        private static void UpdateMethod(ITCDBDataContext ctx)
        {
            int ecode, salary;
            Console.WriteLine("Enter ecode:");
            ecode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            salary = int.Parse(Console.ReadLine());

            var record = ctx.tbl_employees
                            .Where(o => o.ecode == ecode)
                            .SingleOrDefault();

            record.salary = salary;
            ctx.SubmitChanges();
            Console.WriteLine("Record updated");
        }

        private static void DeleteMethod(ITCDBDataContext ctx)
        {
            Console.WriteLine("Enter ecode:");
            int ecode = int.Parse(Console.ReadLine());
            var record = ctx.tbl_employees
                            .Where(o => o.ecode == ecode)
                            .SingleOrDefault();

            ctx.tbl_employees.DeleteOnSubmit(record);
            //save to DB
            ctx.SubmitChanges();
            Console.WriteLine("Record deleted");
        }

        private static void InsertMethod(ITCDBDataContext ctx)
        {
            //add new record
            //Take user input
            Employee record = new Employee();
            Console.WriteLine("Enter ecode:");
            record.Ecode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ename:");
            record.Ename = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            record.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter deptid:");
            record.Deptid = int.Parse(Console.ReadLine());
            //Insert using DB Context

            ctx.tbl_employees.InsertOnSubmit(new tbl_employee
            {
                ecode = record.Ecode,
                ename = record.Ename,
                salary = record.Salary,
                deptid = record.Deptid
            });
            //save to DB using context
            ctx.SubmitChanges();
            Console.WriteLine("Record inserted");
        }
    }
}
