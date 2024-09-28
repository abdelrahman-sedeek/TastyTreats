﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TastyTreats.Contexts;

#nullable disable

namespace TastyTreats.Migrations
{
    [DbContext(typeof(TastyTreatsContext))]
    [Migration("20240926223012_removePriceFromOrderItem")]
    partial class removePriceFromOrderItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TastyTreats.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            CartId = 1,
                            UserId = 1
                        },
                        new
                        {
                            CartId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ItemId");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            CartItemId = 1,
                            CartId = 1,
                            ItemId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            CartItemId = 2,
                            CartId = 2,
                            ItemId = 2,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Various types of drinks.",
                            Name = "Beverages"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Tasty snacks and munchies.",
                            Name = "Snacks"
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ItemPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Availability = true,
                            CategoryId = 1,
                            Description = "Refreshing cola drink.",
                            Discount = 0.50m,
                            ItemPicture = "coke.png",
                            Name = "Coke",
                            Price = 1.99m
                        },
                        new
                        {
                            ItemId = 2,
                            Availability = true,
                            CategoryId = 2,
                            Description = "Crunchy potato chips.",
                            ItemPicture = "chips.png",
                            Name = "Chips",
                            Price = 2.49m
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CreatedAt = new DateTime(2024, 9, 27, 1, 30, 10, 877, DateTimeKind.Local).AddTicks(5659),
                            OrderStatus = "Completed",
                            TotalPrice = 5.97m,
                            UserId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            CreatedAt = new DateTime(2024, 9, 27, 1, 30, 10, 877, DateTimeKind.Local).AddTicks(5732),
                            OrderStatus = "Pending",
                            TotalPrice = 2.49m,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            CreatedAt = new DateTime(2024, 9, 27, 1, 30, 10, 877, DateTimeKind.Local).AddTicks(5777),
                            ItemId = 1,
                            OrderId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 2,
                            CreatedAt = new DateTime(2024, 9, 27, 1, 30, 10, 877, DateTimeKind.Local).AddTicks(5786),
                            ItemId = 2,
                            OrderId = 2,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            City = "New York",
                            Country = "USA",
                            Email = "john.doe@example.com",
                            Name = "John Doe",
                            Password = "Password@123",
                            Phone = 1234567890,
                            Role = "User",
                            UserPicture = "john_picture.png",
                            ZipCode = "12345"
                        },
                        new
                        {
                            UserId = 2,
                            City = "London",
                            Country = "UK",
                            Email = "jane.smith@example.com",
                            Name = "Jane Smith",
                            Password = "11111111",
                            Phone = 1098765432,
                            Role = "Admin",
                            UserPicture = "jane_picture.jpg",
                            ZipCode = "54321"
                        },
                        new
                        {
                            UserId = 3,
                            City = "Toronto",
                            Country = "Canada",
                            Email = "sam.wilson@example.com",
                            Name = "Sam Wilson",
                            Password = "SamWilson@99",
                            Phone = 1987654321,
                            Role = "User",
                            UserPicture = "sam_picture.jpg",
                            ZipCode = "67890"
                        });
                });

            modelBuilder.Entity("TastyTreats.Models.Cart", b =>
                {
                    b.HasOne("TastyTreats.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("TastyTreats.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TastyTreats.Models.CartItem", b =>
                {
                    b.HasOne("TastyTreats.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TastyTreats.Models.Item", "Item")
                        .WithMany("CartItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("TastyTreats.Models.Item", b =>
                {
                    b.HasOne("TastyTreats.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TastyTreats.Models.Order", b =>
                {
                    b.HasOne("TastyTreats.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TastyTreats.Models.OrderItem", b =>
                {
                    b.HasOne("TastyTreats.Models.Item", "Item")
                        .WithMany("OrderItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TastyTreats.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("TastyTreats.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("TastyTreats.Models.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("TastyTreats.Models.Item", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("TastyTreats.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("TastyTreats.Models.User", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
