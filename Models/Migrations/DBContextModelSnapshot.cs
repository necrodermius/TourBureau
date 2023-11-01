﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Models.Operator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("Models.Statement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TourId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("TourId");

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("Models.Tour", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Days")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OperatorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("OperatorId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("Models.Statement", b =>
                {
                    b.HasOne("Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Models.Tour", b =>
                {
                    b.HasOne("Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Operator", "Operator")
                        .WithMany()
                        .HasForeignKey("OperatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Operator");
                });
#pragma warning restore 612, 618
        }
    }
}