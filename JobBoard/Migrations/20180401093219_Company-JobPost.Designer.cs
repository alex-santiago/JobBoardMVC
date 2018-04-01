﻿// <auto-generated />
using JobBoard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace JobBoard.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180401093219_Company-JobPost")]
    partial class CompanyJobPost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobBoard.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("JobBoard.Models.JobPost", b =>
                {
                    b.Property<int>("JobPostID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<DateTime?>("CloseDate");

                    b.Property<int>("CompanyID");

                    b.Property<string>("CountryCode");

                    b.Property<string>("Description");

                    b.Property<DateTime>("PostDate");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StateCode");

                    b.Property<string>("Title");

                    b.HasKey("JobPostID");

                    b.HasIndex("CompanyID");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("JobBoard.Models.JobPost", b =>
                {
                    b.HasOne("JobBoard.Models.Company", "Company")
                        .WithMany("jobPosts")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
