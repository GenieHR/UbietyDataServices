﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin.Models
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
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceFlag> AttendanceFlags { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmpStatu> EmpStatus { get; set; }
        public virtual DbSet<EntityAddress> EntityAddresses { get; set; }
        public virtual DbSet<EntityType> EntityTypes { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<attendance_bak> attendance_bak { get; set; }
        public virtual DbSet<EmpClient> EmpClients { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}
