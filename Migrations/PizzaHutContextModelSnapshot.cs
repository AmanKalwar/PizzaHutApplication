﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaHut.Models;

namespace PizzaHutApplication.Migrations
{
    [DbContext(typeof(PizzaHutContext))]
    partial class PizzaHutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaHut.Models.OrderDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int>("ToppingsID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Order_ID");

                    b.HasIndex("ToppingsID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PizzaHut.Models.Orders", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pizza_ID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Order_ID");

                    b.HasIndex("Pizza_ID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaHut.Models.Pizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Crust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Speicality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            ID = 1001,
                            Crust = "Fresh Pan Pizza",
                            Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese",
                            Images = "/images/pizza-1.jpg",
                            Name = "Veg Loaded",
                            Price = 199.0,
                            Speicality = "with Pepse"
                        },
                        new
                        {
                            ID = 1002,
                            Crust = "Fresh Pan Pizza",
                            Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese",
                            Images = "/images/pizza-2.jpg",
                            Name = "Peppy Paneer Pizza",
                            Price = 299.0,
                            Speicality = "with extra toppings"
                        },
                        new
                        {
                            ID = 1003,
                            Crust = "Fresh Pan Pizza",
                            Description = "Mashroon Topped",
                            Images = "/images/pizza-3.jpg",
                            Name = "Peper Chicken",
                            Price = 199.0,
                            Speicality = "with Pepse"
                        },
                        new
                        {
                            ID = 1004,
                            Crust = "Fresh Pan Pizza",
                            Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese",
                            Images = "/images/pizza-4.jpg",
                            Name = "Non Veg Loaded",
                            Price = 299.0,
                            Speicality = "with Pepse"
                        });
                });

            modelBuilder.Entity("PizzaHut.Models.Toppings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            ID = 201,
                            Name = "Tomato",
                            Price = 99.0
                        },
                        new
                        {
                            ID = 202,
                            Name = "Cheese",
                            Price = 89.0
                        },
                        new
                        {
                            ID = 203,
                            Name = "Onion",
                            Price = 100.0
                        });
                });

            modelBuilder.Entity("PizzaHut.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            Address = "#12/33 Jp Nagar 7th phase Putenahalli bangalore-560078",
                            Name = "Ajith",
                            Password = "Ajithama@19",
                            Phone = "8971950713",
                            UserID = "am9452197@gmail.com"
                        },
                        new
                        {
                            ID = 102,
                            Address = "#113 Attibele sarjapura bangalore-56125",
                            Name = "Lohit",
                            Password = "Lohit@99",
                            Phone = "8310085985",
                            UserID = "lohit01091999@gmail.com"
                        });
                });

            modelBuilder.Entity("PizzaHut.Models.OrderDetails", b =>
                {
                    b.HasOne("PizzaHut.Models.Orders", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaHut.Models.Toppings", "Toppings")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ToppingsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("PizzaHut.Models.Orders", b =>
                {
                    b.HasOne("PizzaHut.Models.Pizza", "Pizza")
                        .WithMany("Orders")
                        .HasForeignKey("Pizza_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaHut.Models.Users", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PizzaHut.Models.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PizzaHut.Models.Pizza", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaHut.Models.Toppings", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PizzaHut.Models.Users", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
