﻿// <auto-generated />
using HomeLibrary.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeLibrary.DAL.Migrations
{
    [DbContext(typeof(HomeLibraryDbContext))]
    partial class HomeLibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            AuthorsId = 1,
                            BooksId = 1
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksId = 2
                        },
                        new
                        {
                            AuthorsId = 2,
                            BooksId = 3
                        },
                        new
                        {
                            AuthorsId = 3,
                            BooksId = 3
                        });
                });

            modelBuilder.Entity("BookTag", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("BookTag");

                    b.HasData(
                        new
                        {
                            BooksId = 1,
                            TagsId = 1
                        },
                        new
                        {
                            BooksId = 1,
                            TagsId = 3
                        },
                        new
                        {
                            BooksId = 2,
                            TagsId = 2
                        });
                });

            modelBuilder.Entity("HomeLibrary.DAL.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "F1",
                            LastName = "L1"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "F2",
                            LastName = "L2"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "F3",
                            LastName = "L3"
                        });
                });

            modelBuilder.Entity("HomeLibrary.DAL.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<int>("PublishDate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ISBN")
                        .IsUnique()
                        .HasFilter("[ISBN] IS NOT NULL");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ISBN = "9784353434",
                            NumberOfPages = 10,
                            PublishDate = 2013,
                            Title = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            ISBN = "9784300434",
                            NumberOfPages = 20,
                            PublishDate = 2014,
                            Title = "Title2"
                        },
                        new
                        {
                            Id = 3,
                            ISBN = "9784340434",
                            NumberOfPages = 30,
                            PublishDate = 2015,
                            Title = "Title3"
                        });
                });

            modelBuilder.Entity("HomeLibrary.DAL.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("Url")
                        .IsUnique();

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Url = "image1"
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            Url = "image2"
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            Url = "image3"
                        },
                        new
                        {
                            Id = 4,
                            BookId = 1,
                            Url = "image4"
                        },
                        new
                        {
                            Id = 5,
                            BookId = 2,
                            Url = "image5"
                        });
                });

            modelBuilder.Entity("HomeLibrary.DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "книга 2021"
                        },
                        new
                        {
                            Id = 2,
                            Name = "музыка"
                        },
                        new
                        {
                            Id = 3,
                            Name = "наука"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("HomeLibrary.DAL.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeLibrary.DAL.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookTag", b =>
                {
                    b.HasOne("HomeLibrary.DAL.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeLibrary.DAL.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeLibrary.DAL.Entities.Image", b =>
                {
                    b.HasOne("HomeLibrary.DAL.Entities.Book", "Book")
                        .WithMany("Images")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("HomeLibrary.DAL.Entities.Book", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
