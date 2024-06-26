﻿using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen
{
    internal class SmartCanteenContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoicesItems { get; set; }

        public SmartCanteenContext() : base("name=SmartCanteenContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .HasMany(t => t.Dishes)
                .WithMany(t => t.Menus);

            modelBuilder.Entity<Menu>()
                .HasMany(t => t.Extras)
                .WithMany(t => t.Menus);

            modelBuilder.Entity<Reservation>()
                .HasRequired<Menu>(r => r.Menu)
                .WithMany(m => m.Reservations)
                .HasForeignKey<int>(r => r.MenuID);

            modelBuilder.Entity<Reservation>()
                .HasRequired<User>(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey<int>(r => r.UserID);

            modelBuilder.Entity<Reservation>()
                .HasRequired<Dish>(r => r.Dish)
                .WithMany(u => u.Reservations)
                .HasForeignKey<int>(r => r.DishID);

            modelBuilder.Entity<Reservation>()
                .HasMany(r => r.Extras)
                .WithMany(e => e.Reservations);

            modelBuilder.Entity<User>()
            .Map<Client>(m => m.Requires("UserType").HasValue("Client"));
        }
    }
}
