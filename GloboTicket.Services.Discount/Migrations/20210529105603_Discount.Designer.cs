﻿// <auto-generated />
using System;
using GloboTicket.Services.Discount.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GloboTicket.Services.Discount.Migrations
{
    [DbContext(typeof(DiscountDbContext))]
    [Migration("20210529105603_Discount")]
    partial class Discount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GloboTicket.Services.Discount.Entities.Coupon", b =>
                {
                    b.Property<Guid>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = new Guid("1d2c80cc-fbca-424e-a048-8522e2c73037"),
                            Amount = 10,
                            UserId = new Guid("e455a3df-7fa5-47e0-8435-179b300d531f")
                        },
                        new
                        {
                            CouponId = new Guid("89bdeb1c-ddc0-477b-bb31-1d0d730e07d4"),
                            Amount = 20,
                            UserId = new Guid("bbf594b0-3761-4a65-b04c-eec4836d9070")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
