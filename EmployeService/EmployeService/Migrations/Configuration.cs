﻿namespace EmployeService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeService.Models;
   

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeService.Models.EmployeeServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeService.Models.EmployeeServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Departments.AddOrUpdate(x => x.Id,
            new Department() { Id = 100, Name ="HR"},
            new Department() { Id=101,Name="Technical"}
            );
            context.Employee.AddOrUpdate(x=>x.Id,
                new Employee() { Id=1,FirstName="John",LastName="Smith",DepartmentId=101,Salary=30000},
                new Employee() { Id=2, FirstName = "Mary",LastName = "Jane",DepartmentId = 102,Salary=20000 },
                new Employee() { Id=3,FirstName = "Steve",LastName = "Lopez",DepartmentId = 103,Salary=50000 }
        }
    }
}
