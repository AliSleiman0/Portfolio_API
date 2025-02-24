﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Portfolio.Infrastructure.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20250224144450_skills")]
    partial class skills
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Portfolio.Domain.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstP")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_p");

                    b.Property<string>("FourthP")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("fourth_p");

                    b.Property<string>("SecondP")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("second_p");

                    b.Property<string>("ThirdP")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("third_p");

                    b.HasKey("Id");

                    b.ToTable("about");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.NetApiProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("GithubUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("github_url");

                    b.Property<string>("LiveDemoUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("live_demo_url");

                    b.Property<string>("TechUsed")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tech_used");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("net_api_projects");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.PhpProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("GithubUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("github_url");

                    b.Property<string>("LiveDemoUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("live_demo_url");

                    b.Property<string>("TechUsed")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tech_used");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("php_projects");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.ReactTsProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("GithubUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("github_url");

                    b.Property<string>("LiveDemoUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("live_demo_url");

                    b.Property<string>("TechUsed")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tech_used");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("react_ts_projects");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.SkillsB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_name");

                    b.HasKey("Id");

                    b.ToTable("skills_b");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.SkillsF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_name");

                    b.HasKey("Id");

                    b.ToTable("skills_f");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.SkillsG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skill_name");

                    b.HasKey("Id");

                    b.ToTable("skills_g");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GithubUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("github_url");

                    b.Property<string>("InstaUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("insta_url");

                    b.Property<string>("LinkedinUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("linkedin_url");

                    b.HasKey("Id");

                    b.ToTable("socials");
                });

            modelBuilder.Entity("Portfolio.Domain.Models.Welcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("img_src");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("skills");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("subtitle");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("welcome");
                });
#pragma warning restore 612, 618
        }
    }
}
