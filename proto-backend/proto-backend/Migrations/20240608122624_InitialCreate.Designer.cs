﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proto_backend.Context;

#nullable disable

namespace proto_backend.Migrations
{
    [DbContext(typeof(MuscleContext))]
    [Migration("20240608122624_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("proto_backend.Models.PartMaster", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PartId");

                    b.ToTable("PartMasters");
                });
#pragma warning restore 612, 618
        }
    }
}
