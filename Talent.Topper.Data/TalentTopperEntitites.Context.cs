﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Talent.Topper.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TalentTopperEntities : DbContext
    {
        public TalentTopperEntities()
            : base("name=TalentTopperEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COUNTRY_MASTER> COUNTRY_MASTER { get; set; }
        public virtual DbSet<DISTRICT_MASTER> DISTRICT_MASTER { get; set; }
        public virtual DbSet<IDMaster> IDMasters { get; set; }
        public virtual DbSet<LOG_COUNT> LOG_COUNT { get; set; }
        public virtual DbSet<MENU_MASTER> MENU_MASTER { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<ROLE_PERMISSION> ROLE_PERMISSION { get; set; }
        public virtual DbSet<STATE_MASTER> STATE_MASTER { get; set; }
        public virtual DbSet<BRANCH> BRANCHes { get; set; }
        public virtual DbSet<ADDRESS> ADDRESSes { get; set; }
        public virtual DbSet<COMPANY> COMPANies { get; set; }
        public virtual DbSet<CONTACT> CONTACTs { get; set; }
    }
}
