using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{   // Db tabloları ile proje classlarına bağlamak.
    public class PhotographerContext : DbContext
    {   // Created Database on my local
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LNTHMCF\SQLEXPRESS;Database=PhotographerDB;Integrated Security=SSPI");
        }

        // Created TableName on  my DataBase
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<EmployeeWork> EmployeeWorks { get; set; }
        public DbSet<WorkingType> WorkingTypes { get; set; }
        public DbSet<DailyRecord> DailyRecords { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppoinmentDate> AppoinmentDates { get; set; }
        public DbSet<AppointmentType> AppointmentTypes{ get; set; }


    }
}
