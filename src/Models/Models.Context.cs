﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITech.Security.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SecurityDB : DbContext
    {
        public SecurityDB()
            : base("name=SecurityDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<RoleOperation> RoleOperations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleView> RoleViews { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<View> Views { get; set; }
    }
}