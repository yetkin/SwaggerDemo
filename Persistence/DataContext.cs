﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Value> Values
        {
            get; set;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                      new Value { Id = 1, Name = "value 1" },
                      new Value { Id = 2, Name = "value 2" },
                      new Value { Id = 3, Name = "value 3" }
                );
        }
    }
}
