﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetManagementAngularProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AssetMVCEntities : DbContext
    {
        public AssetMVCEntities()
            : base("name=AssetMVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asset_def> Asset_def { get; set; }
        public virtual DbSet<Asset_master> Asset_master { get; set; }
        public virtual DbSet<Asset_type> Asset_type { get; set; }
        public virtual DbSet<Login_tbl> Login_tbl { get; set; }
        public virtual DbSet<Purchase_order> Purchase_order { get; set; }
        public virtual DbSet<status_tbl> status_tbl { get; set; }
        public virtual DbSet<User_registration> User_registration { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
    }
}
