﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrmProductes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class SecureCoreG4Entities1 : DbContext
    {
        public SecureCoreG4Entities1()
        : base("name=SecureCoreG4Entities1")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .HasRequired(p => p.Factories)
                .WithMany(f => f.Products)
                .HasForeignKey(p => p.idFactory);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Factories> Factories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
    }
}
