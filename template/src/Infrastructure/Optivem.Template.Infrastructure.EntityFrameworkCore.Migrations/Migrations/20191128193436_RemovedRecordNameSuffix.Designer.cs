﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Optivem.Template.Infrastructure.EntityFrameworkCore;

namespace Optivem.Template.Infrastructure.EntityFrameworkCore.Migrations.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191128193436_RemovedRecordNameSuffix")]
    partial class RemovedRecordNameSuffix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Customers.CustomerRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderDetailRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("OrderDetailStatusId")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailStatusId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderDetailStatusRecord", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("OrderDetailStatuses");

                    b.HasData(
                        new
                        {
                            Id = (byte)0,
                            Code = "None"
                        },
                        new
                        {
                            Id = (byte)1,
                            Code = "Allocated"
                        },
                        new
                        {
                            Id = (byte)2,
                            Code = "Invoiced"
                        },
                        new
                        {
                            Id = (byte)3,
                            Code = "Shipped"
                        },
                        new
                        {
                            Id = (byte)4,
                            Code = "OnOrder"
                        },
                        new
                        {
                            Id = (byte)5,
                            Code = "NoStock"
                        });
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("OrderStatusId")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderStatusRecord", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = (byte)0,
                            Code = "None"
                        },
                        new
                        {
                            Id = (byte)1,
                            Code = "New"
                        },
                        new
                        {
                            Id = (byte)2,
                            Code = "Invoiced"
                        },
                        new
                        {
                            Id = (byte)3,
                            Code = "Shipped"
                        },
                        new
                        {
                            Id = (byte)4,
                            Code = "Closed"
                        },
                        new
                        {
                            Id = (byte)7,
                            Code = "Submitted"
                        },
                        new
                        {
                            Id = (byte)8,
                            Code = "Cancelled"
                        },
                        new
                        {
                            Id = (byte)9,
                            Code = "Archived"
                        });
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Products.ProductRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsListed")
                        .HasColumnType("bit");

                    b.Property<decimal>("ListPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderDetailRecord", b =>
                {
                    b.HasOne("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderDetailStatusRecord", "OrderDetailStatus")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderDetailStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderRecord", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Optivem.Template.Infrastructure.EntityFrameworkCore.Products.ProductRecord", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderRecord", b =>
                {
                    b.HasOne("Optivem.Template.Infrastructure.EntityFrameworkCore.Customers.CustomerRecord", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Optivem.Template.Infrastructure.EntityFrameworkCore.Orders.OrderStatusRecord", "OrderStatus")
                        .WithMany("OrderRecords")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
