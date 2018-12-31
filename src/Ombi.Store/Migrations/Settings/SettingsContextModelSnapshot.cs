﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ombi.Store.Context;

namespace Ombi.Store.Migrations.Settings
{
    [DbContext(typeof(SettingsContext))]
    partial class SettingsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("Ombi.Store.Entities.ApplicationConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Type");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("ApplicationConfiguration");
                });

            modelBuilder.Entity("Ombi.Store.Entities.GlobalSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("SettingsName");

                    b.HasKey("Id");

                    b.ToTable("GlobalSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
