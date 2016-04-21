﻿using Control.Model.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Data
{
    public class ControlContext : IdentityDbContext<User>
    {
        private DbConnection _objCn;


            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Country> Countries { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderProduct> OrdersProducts { get; set; }
            public DbSet<OrderType> OrdersTypes { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Provider> Providers { get; set; }
            public DbSet<Stock> Stocks { get; set; }
            public DbSet<Storage> Storages { get; set; }
            public DbSet<TypeUnit> TypesUnities { get; set; }
            public DbSet<Unit> Unities { get; set; }
            public DbSet<Vendor> Vendors { get; set; }

        public ControlContext()
            : base(DBConexao.GetConnectionString(), throwIfV1Schema: false)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ControlContext>());
        }

        public ControlContext(DbConnection cn)
            : base(cn, true)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MLogisticContext>());
        }

        public static ControlContext Create()
        {
            return new ControlContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<User>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<Transaction>().ToTable("Transaction");
            
            //modelBuilder.Entity<Contact>();
            //modelBuilder.Entity<Country>();
            //modelBuilder.Entity<Customer>();
            //modelBuilder.Entity<Order>();
            //modelBuilder.Entity<OrderProduct>();
            //modelBuilder.Entity<OrderType>();
            //modelBuilder.Entity<Product>();
            //modelBuilder.Entity<Provider>();
            //modelBuilder.Entity<Stock>();
            //modelBuilder.Entity<Storage>();
            //modelBuilder.Entity<TypeUnit>();
            //modelBuilder.Entity<Unit>();
            //modelBuilder.Entity<Vendor>();
        }

        public System.Data.Entity.DbSet<Control.Model.Entities.Transaction> Transactions { get; set; }



        //public DbSet<User> Users { get; set; }
    }
}
