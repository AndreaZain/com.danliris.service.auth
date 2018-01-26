﻿// <auto-generated />
using Com.DanLiris.Service.Auth.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.DanLiris.Service.Auth.Lib.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    [Migration("20180122044706_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Password")
                        .HasMaxLength(255);

                    b.Property<string>("Username")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.AccountProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<string>("Firstname")
                        .HasMaxLength(255);

                    b.Property<string>("Gender")
                        .HasMaxLength(6);

                    b.Property<string>("Lastname")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("AccountProfiles");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.AccountRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<bool>("Active");

                    b.Property<int>("RoleId");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Division")
                        .HasMaxLength(255);

                    b.Property<int>("RoleId");

                    b.Property<string>("Unit")
                        .HasMaxLength(255);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<int>("UnitId");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.Property<int>("permission");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.AccountProfile", b =>
                {
                    b.HasOne("Com.DanLiris.Service.Auth.Lib.Models.Account", "Account")
                        .WithOne("AccountProfile")
                        .HasForeignKey("Com.DanLiris.Service.Auth.Lib.Models.AccountProfile", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.AccountRole", b =>
                {
                    b.HasOne("Com.DanLiris.Service.Auth.Lib.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Com.DanLiris.Service.Auth.Lib.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.DanLiris.Service.Auth.Lib.Models.Permission", b =>
                {
                    b.HasOne("Com.DanLiris.Service.Auth.Lib.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}