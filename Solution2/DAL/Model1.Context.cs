﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Inventory_MVC2Entities1 : DbContext
    {
        public Inventory_MVC2Entities1()
            : base("name=Inventory_MVC2Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADDTARIF> ADDTARIFs { get; set; }
    
        public virtual ObjectResult<mayank_Result> mayank(string sp)
        {
            var spParameter = sp != null ?
                new ObjectParameter("sp", sp) :
                new ObjectParameter("sp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<mayank_Result>("mayank", spParameter);
        }
    }
}
