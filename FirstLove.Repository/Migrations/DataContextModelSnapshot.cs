﻿// <auto-generated />
using FirstLove.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstLove.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FirstLove.Repository.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BriefIntroduction")
                        .HasMaxLength(288);

                    b.Property<string>("HeadImg")
                        .HasMaxLength(100);

                    b.Property<string>("Mail")
                        .HasMaxLength(30);

                    b.Property<string>("NickName")
                        .HasMaxLength(18);

                    b.HasKey("UserId");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
