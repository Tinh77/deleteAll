﻿// <auto-generated />
using AppCuaToi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppCuaToi.Migrations
{
    [DbContext(typeof(MyDataContext))]
    [Migration("20181103034926_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppCuaToi.Models.Category", b =>
                {
                    b.Property<long>("id");

                    b.Property<string>("createAt");

                    b.Property<string>("description");

                    b.Property<string>("name");

                    b.Property<string>("updateAt");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AppCuaToi.Models.Product", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("categoryId");

                    b.Property<string>("createAt");

                    b.Property<string>("description");

                    b.Property<string>("name");

                    b.Property<string>("thumbnail");

                    b.Property<string>("updateAt");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AppCuaToi.Models.Product", b =>
                {
                    b.HasOne("AppCuaToi.Models.Category", "Category")
                        .WithMany("ListProduct")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
