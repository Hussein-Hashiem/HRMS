using HRMS.Database;
using HRMS.Models;
using System;

namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var employees = new List<Employee>()
            {
                new Employee() {name = "Hamam", position = "Prof", departmentId = 2},
                new Employee() {name = "Ahmed", position = "Assistant", departmentId = 4},
                new Employee() {name = "Hussein", position = "Assistant", departmentId = 2},
                new Employee() {name = "Khaled", position = "CyberCecurity", departmentId = 3},
            };

            foreach(var employee in employees)
            {
                context.Employees.Add(employee);
            }

            context.SaveChanges();
        }
    }
}
            //var departments = new List<Department>()
            //{
            //    new Department() { name = "HR"},
            //    new Department() {name = "CS"}, 
            //    new Department() {name = "IT"}, 
            //    new Department() {name = "AI"}
            //};

            //foreach(var department in departments)
            //{
            //    context.Departments.Add(department);
            //}