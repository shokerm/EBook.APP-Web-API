﻿// <auto-generated />
using System;
using EBook.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EBook.API.Migrations
{
    [DbContext(typeof(StoreDBContext))]
    [Migration("20230611162155_Mig5")]
    partial class Mig5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EBook.API.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LikeToggleStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageAlt = "javascript-book",
                            ImageUrl = "../../../../assets//images/store-images/javascript-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "JavaScript",
                            Price = 99.900000000000006,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageAlt = "entity-framework-book",
                            ImageUrl = "../../../../assets//images/store-images/entity-framework-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "Entity Framework",
                            Price = 79.900000000000006,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            ImageAlt = "jQuery",
                            ImageUrl = "../../../../assets//images/store-images/jquery-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "jQuery",
                            Price = 59.899999999999999,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            ImageAlt = "Powershell",
                            ImageUrl = "../../../../assets//images/store-images/powershell-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "Powershell",
                            Price = 49.899999999999999,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            ImageAlt = "ReactJS",
                            ImageUrl = "../../../../assets//images/store-images/reactjs-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "ReactJS",
                            Price = 299.89999999999998,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 6,
                            ImageAlt = "Git",
                            ImageUrl = "../../../../assets//images/store-images/git-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "Git",
                            Price = 99.900000000000006,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            ImageAlt = "Ruby on Rails",
                            ImageUrl = "../../../../assets//images/store-images/ruby-on-rails-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "Ruby on Rails",
                            Price = 99.900000000000006,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            ImageAlt = "Oracle Database",
                            ImageUrl = "../../../../assets//images/store-images/oracle-database-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "Oracle Database",
                            Price = 99.900000000000006,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 9,
                            ImageAlt = "image-3",
                            ImageUrl = "../../../../assets//images/store-images/ios-developer-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "IOS Developer ",
                            Price = 149.90000000000001,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 10,
                            ImageAlt = "Visual Basic .NET",
                            ImageUrl = "../../../../assets//images/store-images/visual-basic-dotnet-book.jpg",
                            LikeToggleStatus = "favorite_border",
                            Name = "Visual Basic .NET",
                            Price = 49.899999999999999,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("EBook.API.Data.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("EBook.API.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AuthLevel")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            AuthLevel = 2,
                            ConcurrencyStamp = "f2e66c89-b519-4ba7-bd94-86e1081d5db1",
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPVgIpL1l9O+8jC5SiACTHei4li7EnTIOCAfKijGjk5L9q+Z5wriDpjBs+6yY7JpsA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "426f0abf-4d40-4dc3-a699-6f69c9d77aa4",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            AccessFailedCount = 0,
                            AuthLevel = 1,
                            ConcurrencyStamp = "724d9cf3-df65-4b84-b50b-ea34838e915f",
                            Email = "yoni@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "YONI@EMAIL.COM",
                            NormalizedUserName = "YONI",
                            PasswordHash = "AQAAAAEAACcQAAAAEC48sGEJLnX/7FUyTCKzxWm/zs/nNhGg8EdQ0I29zPT0QkMYFuxccWUKdTMl8G0t/Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f68535b2-c1a3-4b70-acd4-e839c5b720c5",
                            TwoFactorEnabled = false,
                            UserName = "Yoni"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                            ConcurrencyStamp = "e39f4a96-80ca-410c-849a-f413f0c26f9b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            ConcurrencyStamp = "cece3b2b-82f6-46f1-9d5b-5258e4ecc431",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                            ConcurrencyStamp = "c8c470be-4cbc-4c51-a1b4-e13fa1a801cd",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "c32f66ed-c960-4cb7-a468-90662e1fb37a"
                        },
                        new
                        {
                            UserId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EBook.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EBook.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EBook.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EBook.API.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
