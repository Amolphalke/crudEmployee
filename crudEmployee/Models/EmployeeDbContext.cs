﻿using Microsoft.EntityFrameworkCore;
namespace crudemployee.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
