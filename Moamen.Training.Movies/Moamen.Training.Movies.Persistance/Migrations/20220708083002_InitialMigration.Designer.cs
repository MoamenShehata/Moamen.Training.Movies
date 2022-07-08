﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moamen.Training.Movies.Persistance;

#nullable disable

namespace Moamen.Training.Movies.Persistance.Migrations
{
    [DbContext(typeof(MoviesDataContext))]
    [Migration("20220708083002_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Common.MovieGenres", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MoviesGenres", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Common.MovieMembers", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("MovieMemberId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "MovieMemberId");

                    b.HasIndex("MovieMemberId");

                    b.ToTable("MoviesMembers", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Common.MovieUsers", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MovieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MoviesUsers", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.CrewMembers.MovieMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(5);

                    b.Property<double>("HeightInInches")
                        .HasColumnType("float")
                        .HasColumnOrder(7);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnOrder(6);

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.ToTable("MovieMembers", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Gallery.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MediaType")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Medias", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Movies.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.ToTable("Genres", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Movies.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brief")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time")
                        .HasColumnOrder(3);

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.ToTable("Movies", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Common.MovieGenres", b =>
                {
                    b.HasOne("Moamen.Training.Movies.Domain.Movies.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moamen.Training.Movies.Domain.Movies.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Common.MovieMembers", b =>
                {
                    b.HasOne("Moamen.Training.Movies.Domain.Movies.Movie", "Movie")
                        .WithMany("MovieMembers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moamen.Training.Movies.Domain.CrewMembers.MovieMember", "MovieMember")
                        .WithMany("MovieMembers")
                        .HasForeignKey("MovieMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("MovieMember");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Common.MovieUsers", b =>
                {
                    b.HasOne("Moamen.Training.Movies.Domain.Movies.Movie", "Movie")
                        .WithMany("MovieUsers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moamen.Training.Movies.Domain.Users.User", "User")
                        .WithMany("MovieUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Gallery.Media", b =>
                {
                    b.HasOne("Moamen.Training.Movies.Domain.Movies.Movie", "Movie")
                        .WithMany("Medias")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.CrewMembers.MovieMember", b =>
                {
                    b.Navigation("MovieMembers");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Movies.Genre", b =>
                {
                    b.Navigation("MovieGenres");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Movies.Movie", b =>
                {
                    b.Navigation("Medias");

                    b.Navigation("MovieGenres");

                    b.Navigation("MovieMembers");

                    b.Navigation("MovieUsers");
                });

            modelBuilder.Entity("Moamen.Training.Movies.Domain.Users.User", b =>
                {
                    b.Navigation("MovieUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
