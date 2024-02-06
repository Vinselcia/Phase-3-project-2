﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolApplicationCrud.Data;

#nullable disable

namespace SchoolApplicationCrud.Migrations.ClassesDb
{
    [DbContext(typeof(ClassesDbContext))]
    partial class ClassesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolApplicationCrud.Models.Classes", b =>
                {
                    b.Property<string>("Class_Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class_Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Class_Name");

                    b.ToTable("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}
