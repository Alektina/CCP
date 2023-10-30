using System;
using Microsoft.EntityFrameworkCore;
using MVCDog.Models;

namespace MVCDog
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Breeder> Breeders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Kennel> Kennels { get; set; }
        public DbSet<Litter> Litters { get; set; }
        public DbSet<Merit> Merits { get; set; }        
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Country> Countries{ get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // Table Dogs
            modelBuilder.Entity<Dog>().HasData(
                new Dog
                {
                    Id = 1,
                    Name = "Sirocco Lunatic Toc Tamarine",
                    Nickname = "Morgan",
                    Reg_number = "SE23916/2016", 
                   
                    Color = "Blue with white markings",
                    Weight = "5 kg",
                    Height = "32 cm",
                    Hairlayers = "Hailless",
                    DogId_Father = 2,
                    DogId_Mother = 3
                    
                });
            modelBuilder.Entity<Dog>().HasData(
                new Dog
                {
                    Id = 2,
                    Name = "Hooki z Teramonu",
                    Nickname = "Hooki",
                    Reg_number = "SE59047/2012",
                    
                    Color = "Spotted",
                    Weight = "5 kg",
                    Height = "33 cm",
                    Hairlayers = "Hailless"                   
                   

                });
            modelBuilder.Entity<Dog>().HasData(
                new Dog
                {
                    Id = 3,
                    Name = "Sirocco Endless Locks Of Eventide",
                    Nickname = "Viska",
                    Reg_number = "SE29122/2013",
                    
                    Color = "Spotted",
                    Weight = "5 kg",
                    Height = "33 cm",
                    Hairlayers= "Hailless"

                });
            //Table Breeders

            modelBuilder.Entity<Breeder>().HasData(
                new Breeder
                {
                    Id = 1,
                    Name = "Elin Gunnarsson",
                    DogId = 1,
                    ContactId = 1

                });
            //Table Kennel

            modelBuilder.Entity<Kennel>().HasData(
                new Kennel
                {
                    Id = 1,
                    Name = "Sirocco",
                    BreederId = 1,
                    ContactId = 1

                });
            //Table Contact
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    Email = "kennelsirocco@gmail.com",
                    Phone_nr = 0703022152,
                    Address = "Torpavägen 60, 461 77 Sjuntorp",
                    Url = "https://kennelsirocco.com/",
                    Social_media = "https://www.facebook.com/elin.sirocco",
                    Country = "Sweden",
                    About_us = "Sirocco was founded by Elin & Birgitta Gunnarsson in 2005, owners of Chinese Crested Dogs since 1999.\nSince 2017 Elin is the sole owner of the Sirocco prefix."

                });
        }


        public DbSet<MVCDog.Models.Country> Country { get; set; } = default!;
    }
}
