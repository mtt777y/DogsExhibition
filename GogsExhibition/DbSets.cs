using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GogsExhibition.Classes;


namespace GogsExhibition
{
    public class DbSets : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<TypeShow> TypesShow { get; set; }
        public DbSet<SpecificalionOfBreed> SpecificalionsOfBreeds { get; set; }
        public DbSet<ColorOfDog> ColorsOfDogs { get; set; }
        public DbSet<Sex> Sexs { get; set; }
        public DbSet<TypesOfShow> TypesOfShows { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer("Server=MATT-PC\\SQLEXPRESS;DataBase = Dogs; User ID=sa;Password=sa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //base.OnConfiguring(contextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            //modelBuilder.Entity<Word>().HasIndex(u => u.Value).IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
    

