﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240919090728_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("adm_mst_tuser", b =>
                {
                    b.Property<string>("user_gid")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("user_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("user_password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("user_gid");

                    b.ToTable("adm_mst_tuser", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}