﻿namespace ECI.DataRepository.Context
{
    using ECI.Entities.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Dog> Dogs { get; set; }
        
        public DbSet<Breed> Breeds { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    LastName = "Admin",
                    Email = "admin@eci.com",
                    Password = "21232f297a57a5a743894a0e4a801fc3"
                }
            );

            modelBuilder.Entity<Breed>().HasData(
                new Breed { Id = 1, Name = "Doberman", isActive = true },
                new Breed { Id = 2, Name = "French Puddle", isActive = true },
                new Breed { Id = 3, Name = "Boxer", isActive = true });

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=MIPCHP;Database=ECI_DogWalks;Trusted_Connection=True;TrustServerCertificate=True;");
        //    }
        //}
    }
}
