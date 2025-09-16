using C44_G02_EF02.Contexts;
using C44_G02_EF02.Models;
using Microsoft.EntityFrameworkCore;

namespace C44_G02_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ2EFCore
           using  CompanyDbG02Context context = new CompanyDbG02Context();

            //var Emp = context.Employees.FirstOrDefault(E => E.EmpId == 1);//Get

            //Console.WriteLine(Emp.Department.Name);

            // context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


            //Change Tracker 

            //Queries

            //Local Object
            // Employee Emp1 = new Employee()
            // {
            //     Name = "Ahmed",
            //     PhoneNumber = "3234564564",
            //     Email = "Ahmed@gmail.com",
            //     Age = 30,
            //     DOB = DateOnly.FromDateTime(DateTime.Now),
            //     Salary = 8000
            // };
            // context.Employees.Add(Emp1);

            //// context.Set<Employee>().Add(Emp1);
            // context.SaveChanges();

            //Console.WriteLine(context.Entry<Employee>(Emp1).State);//DEST
            //Console.WriteLine("=========================================");
            //context.Employees.Add(Emp1);
            //Console.WriteLine(Emp1.EmpId);
            //Console.WriteLine(context.Entry<Employee>(Emp1).State);
            //Console.WriteLine("=========================================");
            //context.SaveChanges();
            //Console.WriteLine(Emp1.EmpId);
            //Console.WriteLine(context.Entry<Employee>(Emp1).State);

            // var Emp = context.Employees.Where(E => E.EmpId == 1).FirstOrDefault();
            // var Emp1 = context.Employees.AsNoTracking().FirstOrDefault(E => E.EmpId == 1);//Get
            //  Console.WriteLine(context.Entry<Employee>(Emp1).State);

            // var Emp2 = context.Employees.FirstOrDefault(E => E.EmpId == 2);//Get
            //Console.WriteLine(context.Entry<Employee>(Emp2).State);
            //Console.WriteLine(Emp2.Name);

            //Emp2.Name = "Hassan";
            //Console.WriteLine(Emp2.Name);

            //Console.WriteLine(context.Entry<Employee>(Emp).State);
            //context.SaveChanges();
            // Console.WriteLine(context.Entry<Employee>(Emp).State);


            //var Emp = context.Employees.FirstOrDefault(E => E.EmpId == 1);//Get
            //Console.WriteLine(context.Entry<Employee>(Emp).State);
            //context.Employees.Remove(Emp);
            //Console.WriteLine(context.Entry<Employee>(Emp).State);
            //context.SaveChanges();
            //Console.WriteLine(context.Entry<Employee>(Emp).State); 
            #endregion

        }
    }
}
