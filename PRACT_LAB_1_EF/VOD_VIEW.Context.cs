﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRACT_LAB_1_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VodocanalEntities4 : DbContext
    {
        public VodocanalEntities4()
            : base("name=VodocanalEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employeers> Employeers { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<CummonEmpl> CummonEmpl { get; set; }
    }
}
