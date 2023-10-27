﻿// <auto-generated />
using System;
using MVCDog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCDog.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BreederDog", b =>
                {
                    b.Property<int>("BreedersId")
                        .HasColumnType("int");

                    b.Property<int>("DogsId")
                        .HasColumnType("int");

                    b.HasKey("BreedersId", "DogsId");

                    b.HasIndex("DogsId");

                    b.ToTable("BreederDog");
                });

            modelBuilder.Entity("BreederKennel", b =>
                {
                    b.Property<int>("BredeersId")
                        .HasColumnType("int");

                    b.Property<int>("KennelsId")
                        .HasColumnType("int");

                    b.HasKey("BredeersId", "KennelsId");

                    b.HasIndex("KennelsId");

                    b.ToTable("BreederKennel");
                });

            modelBuilder.Entity("DogGallery", b =>
                {
                    b.Property<int>("DogsId")
                        .HasColumnType("int");

                    b.Property<int>("GalleriesId")
                        .HasColumnType("int");

                    b.HasKey("DogsId", "GalleriesId");

                    b.HasIndex("GalleriesId");

                    b.ToTable("DogGallery");
                });

            modelBuilder.Entity("DogOwner", b =>
                {
                    b.Property<int>("DogsId")
                        .HasColumnType("int");

                    b.Property<int>("OwnersId")
                        .HasColumnType("int");

                    b.HasKey("DogsId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("DogOwner");
                });

            modelBuilder.Entity("MVCDog.Models.Breeder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<int>("KennelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Breeders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactId = 1,
                            DogId = 1,
                            KennelId = 0,
                            Name = "Elin Gunnarsson"
                        });
                });

            modelBuilder.Entity("MVCDog.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About_us")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Added_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BreederId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KennelId")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Phone_nr")
                        .HasColumnType("int");

                    b.Property<string>("Social_media")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BreederId");

                    b.HasIndex("KennelId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About_us = "Sirocco was founded by Elin & Birgitta Gunnarsson in 2005, owners of Chinese Crested Dogs since 1999.\nSince 2017 Elin is the sole owner of the Sirocco prefix.",
                            Address = "Torpavägen 60, 461 77 Sjuntorp",
                            Country = "Sweden",
                            Email = "kennelsirocco@gmail.com",
                            Phone_nr = 703022152,
                            Social_media = "https://www.facebook.com/elin.sirocco",
                            Url = "https://kennelsirocco.com/"
                        });
                });

            modelBuilder.Entity("MVCDog.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DogId")
                        .HasColumnType("int");

                    b.HasKey("CountryID");

                    b.HasIndex("DogId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("MVCDog.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birth_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Death_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DogId_Father")
                        .HasColumnType("int");

                    b.Property<int?>("DogId_Mother")
                        .HasColumnType("int");

                    b.Property<string>("Hairlayers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other_info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reg_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Blue with white markings",
                            DogId_Father = 2,
                            DogId_Mother = 3,
                            Hairlayers = "Hailless",
                            Height = "32 cm",
                            Name = "Sirocco Lunatic Toc Tamarine",
                            Nickname = "Morgan",
                            Reg_number = "SE23916/2016",
                            Weight = "5 kg"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Spotted",
                            Hairlayers = "Hailless",
                            Height = "33 cm",
                            Name = "Hooki z Teramonu",
                            Nickname = "Hooki",
                            Reg_number = "SE59047/2012",
                            Weight = "5 kg"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Spotted",
                            Hairlayers = "Hailless",
                            Height = "33 cm",
                            Name = "Sirocco Endless Locks Of Eventide",
                            Nickname = "Viska",
                            Reg_number = "SE29122/2013",
                            Weight = "5 kg"
                        });
                });

            modelBuilder.Entity("MVCDog.Models.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<string>("File_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("MVCDog.Models.Kennel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BreederId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("DogId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.ToTable("Kennels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BreederId = 1,
                            ContactId = 1,
                            Name = "Sirocco"
                        });
                });

            modelBuilder.Entity("MVCDog.Models.Litter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birth_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<int>("FatherId")
                        .HasColumnType("int");

                    b.Property<int>("MotherId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.ToTable("Litters");
                });

            modelBuilder.Entity("MVCDog.Models.Merit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BIS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Best_in_show")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Merit_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Merit_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("National_BISS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Top")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Winner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.ToTable("Merits");
                });

            modelBuilder.Entity("MVCDog.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("MVCDog.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<string>("Title_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("BreederDog", b =>
                {
                    b.HasOne("MVCDog.Models.Breeder", null)
                        .WithMany()
                        .HasForeignKey("BreedersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDog.Models.Dog", null)
                        .WithMany()
                        .HasForeignKey("DogsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BreederKennel", b =>
                {
                    b.HasOne("MVCDog.Models.Breeder", null)
                        .WithMany()
                        .HasForeignKey("BredeersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDog.Models.Kennel", null)
                        .WithMany()
                        .HasForeignKey("KennelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogGallery", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", null)
                        .WithMany()
                        .HasForeignKey("DogsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDog.Models.Gallery", null)
                        .WithMany()
                        .HasForeignKey("GalleriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DogOwner", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", null)
                        .WithMany()
                        .HasForeignKey("DogsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDog.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVCDog.Models.Contact", b =>
                {
                    b.HasOne("MVCDog.Models.Breeder", null)
                        .WithMany("Contacts")
                        .HasForeignKey("BreederId");

                    b.HasOne("MVCDog.Models.Kennel", null)
                        .WithMany("Contacts")
                        .HasForeignKey("KennelId");

                    b.HasOne("MVCDog.Models.Owner", null)
                        .WithMany("Contacts")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("MVCDog.Models.Country", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", null)
                        .WithMany("Countries")
                        .HasForeignKey("DogId");
                });

            modelBuilder.Entity("MVCDog.Models.Kennel", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", null)
                        .WithMany("Kennels")
                        .HasForeignKey("DogId");
                });

            modelBuilder.Entity("MVCDog.Models.Litter", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", "Dog")
                        .WithMany("Litters")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("MVCDog.Models.Merit", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", "Dog")
                        .WithMany("Merits")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("MVCDog.Models.Title", b =>
                {
                    b.HasOne("MVCDog.Models.Dog", "Dog")
                        .WithMany("Titles")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("MVCDog.Models.Breeder", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("MVCDog.Models.Dog", b =>
                {
                    b.Navigation("Countries");

                    b.Navigation("Kennels");

                    b.Navigation("Litters");

                    b.Navigation("Merits");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("MVCDog.Models.Kennel", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("MVCDog.Models.Owner", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
