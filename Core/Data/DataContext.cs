﻿using Microsoft.EntityFrameworkCore;
using Core.Model;
using Type = Core.Model.Type;

namespace Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Company> Company => Set<Company>();
        public DbSet<Department> Department => Set<Department>();
        public DbSet<Approvers> Approvers => Set<Approvers>();
        public DbSet<Profile> Profile => Set<Profile>();
        public DbSet<BrSource> BrSource => Set<BrSource>();
        public DbSet<BrType> BrType => Set<BrType>();
        public DbSet<Level> Level => Set<Level>();
        public DbSet<Type> Type => Set<Type>();
        public DbSet<PlaceOfDelivery> PlaceOfDelivery => Set<PlaceOfDelivery>();

    }
}
