using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
          .HasData(
              new Dog { DogId = 1, Name = "Marvin", Breed = "Labradoodle", Gender = "Male" },
              new Dog { DogId = 2, Name = "Reggie", Breed = "Boston Terrier", Gender = "Male" },
              new Dog { DogId = 3, Name = "Sushi", Breed = "Rat Terrier", Gender = "Female" },
              new Dog { DogId = 4, Name = "Eva", Breed = "Greyhound", Gender = "Female" }
          );
      builder.Entity<Cat>()
          .HasData(
              new Cat { CatId = 1, Name = "Cuddles", Breed = "Tuxedo", Gender = "Female" }
          );
    }
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }
  }
}