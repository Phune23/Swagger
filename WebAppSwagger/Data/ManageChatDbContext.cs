﻿using WebAppSwagger.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebAppSwagger.Data
{
    public class ManageChatDbContext : IdentityDbContext<ManageUser>
    {
        public ManageChatDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().Property(x => x.Id).HasMaxLength(50).IsRequired(true);
            builder.Entity<ManageUser>().Property(x => x.Id).HasMaxLength(50).IsRequired(true);

            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<ManageUser> ManageUsers { get; set; }
        //public DbSet<Room> Rooms { get; set; }
        //public DbSet<Message> Messages { get; set; }

    }
}
