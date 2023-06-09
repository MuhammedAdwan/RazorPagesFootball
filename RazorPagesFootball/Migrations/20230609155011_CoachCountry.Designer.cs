﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RazorPagesFootball.Migrations
{
    [DbContext(typeof(RazorPagesFootballContext))]
    [Migration("20230609155011_CoachCountry")]
    partial class CoachCountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("RazorPagesFootball.Models.Football", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BestPlayer")
                        .HasColumnType("TEXT");

                    b.Property<int>("BestPlayerShirtNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoachCountry")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoachName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EstablishedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("WinningTimes")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Football");
                });
#pragma warning restore 612, 618
        }
    }
}
