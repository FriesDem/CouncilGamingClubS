﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CouncilGamingClub
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CGCAppDatabaseEntities : DbContext
    {
        public CGCAppDatabaseEntities()
            : base("name=CGCAppDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<InventoryTable> InventoryTables { get; set; }
        public virtual DbSet<Login_Page> Login_Pages { get; set; }
        public virtual DbSet<OrdersTable> OrdersTables { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SupplierTable> SupplierTables { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    }
}
