﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UbietyDataServices.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ubietydbEntities : DbContext
    {
        public ubietydbEntities()
            : base("name=ubietydbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceFlag> AttendanceFlags { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpStatu> EmpStatus { get; set; }
        public DbSet<EntityAddress> EntityAddresses { get; set; }
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}