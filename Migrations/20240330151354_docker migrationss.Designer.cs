﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlinePetShopManagementSystem.Models;

#nullable disable

namespace OnlinePetShopManagementSystem.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    [Migration("20240330151354_docker migrationss")]
    partial class dockermigrationss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PetDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("longtext");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("PetDetailsId");

                    b.HasIndex("UsersId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.LoginAdmin", b =>
                {
                    b.Property<int>("AdminUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AdminUserId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.Orderdetails", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessoryId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("AccessoryId");

                    b.HasIndex("UsersId");

                    b.ToTable("Orderdetails");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.PetAccessory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PetAccesoryName")
                        .HasColumnType("longtext");

                    b.Property<string>("PetAccessoryDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("PetAccessoryPrice")
                        .HasColumnType("longtext");

                    b.Property<string>("UniqueFileName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Accessory");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.PetDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PetBreed")
                        .HasColumnType("longtext");

                    b.Property<string>("PetCategory")
                        .HasColumnType("longtext");

                    b.Property<string>("PetDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("PetName")
                        .HasColumnType("longtext");

                    b.Property<long?>("PetPrice")
                        .HasColumnType("bigint");

                    b.Property<int?>("PetStock")
                        .HasColumnType("int");

                    b.Property<string>("UniqueFileName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetDetails");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.Appointment", b =>
                {
                    b.HasOne("OnlinePetShopManagementSystem.Models.PetDetail", "PetDetails")
                        .WithMany()
                        .HasForeignKey("PetDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlinePetShopManagementSystem.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PetDetails");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("OnlinePetShopManagementSystem.Models.Orderdetails", b =>
                {
                    b.HasOne("OnlinePetShopManagementSystem.Models.PetAccessory", "Accessory")
                        .WithMany()
                        .HasForeignKey("AccessoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlinePetShopManagementSystem.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accessory");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
