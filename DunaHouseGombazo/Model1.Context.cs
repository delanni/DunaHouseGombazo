﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DunaHouseGombazo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DHSEntities : DbContext
    {
        public DHSEntities()
            : base("name=DHSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Conditioning> Conditioning { get; set; }
        public DbSet<Extra> Extra { get; set; }
        public DbSet<Heating> Heating { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Image> Image { get; set; }
    }
}
