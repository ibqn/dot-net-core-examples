﻿// <auto-generated />
using DotNetCore.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace dotnetcoresqlite.Migrations
{
    [DbContext(typeof(DataStoreContext))]
    [Migration("20170816140753_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("DotNetCore.SQLite.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("First");

                    b.Property<string>("Last");

                    b.Property<double>("Price");

                    b.Property<string>("State");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("DotNetCore.SQLite.Distributor", b =>
                {
                    b.Property<int>("DistributorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("DistributorId");

                    b.ToTable("distributors");
                });

            modelBuilder.Entity("DotNetCore.SQLite.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<string>("Item");

                    b.HasKey("PurchaseId");

                    b.HasIndex("CustomerId");

                    b.ToTable("purchases");
                });

            modelBuilder.Entity("DotNetCore.SQLite.Purchase", b =>
                {
                    b.HasOne("DotNetCore.SQLite.Customer", "Customer")
                        .WithMany("Purchases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
