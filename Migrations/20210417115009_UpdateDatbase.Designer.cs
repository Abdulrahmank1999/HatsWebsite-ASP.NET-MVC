﻿// <auto-generated />
using System;
using HatSelling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HatSelling.Migrations
{
    [DbContext(typeof(HatsDbContext))]
    [Migration("20210417115009_UpdateDatbase")]
    partial class UpdateDatbase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HatSelling.Models.Buy", b =>
                {
                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HatId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("HatId");

                    b.HasIndex("UserId");

                    b.ToTable("Buys");
                });

            modelBuilder.Entity("HatSelling.Models.Hat", b =>
                {
                    b.Property<int>("HatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HatName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("HatId");

                    b.ToTable("Hats");
                });

            modelBuilder.Entity("HatSelling.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HatSelling.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("RolesRoleId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("HatSelling.Models.Buy", b =>
                {
                    b.HasOne("HatSelling.Models.Hat", "Hat")
                        .WithMany()
                        .HasForeignKey("HatId");

                    b.HasOne("HatSelling.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Hat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("HatSelling.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HatSelling.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
