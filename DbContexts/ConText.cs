using Microsoft.EntityFrameworkCore;
using ThuVienMVC.Models;

namespace ThuVierApi.DbContexts
{
    public class ConText : DbContext
    {
        public ConText(DbContextOptions options): base (options)  { }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Rating> ratings { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Borrowing> borrowings { get; set; }
        public DbSet<BorrowingItems> borrowingItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>(e =>
            {
                e.ToTable("admins");
                e.HasKey(e => e.IdAmin);
                e.Property(e => e.IdAmin)
                .ValueGeneratedOnAdd();
                e.Property(e => e.NameAdmin)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);
                e.Property(e => e.AminName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);
                e.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(true);


            });
            modelBuilder.Entity<Author>(e =>
            {
                e.ToTable("authors");
                e.HasKey(e => e.IdAuthor);
                e.Property(e => e.IdAuthor)
                .ValueGeneratedOnAdd();
                e.Property(e => e.NameAuthor)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);

            });
            modelBuilder.Entity<Genre>(e =>
            {
                e.ToTable("geres");
                e.HasKey(e => e.IdGenres);
                e.Property(e => e.IdGenres)
                .ValueGeneratedOnAdd();
                e.Property(e => e.NameGenres)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);

            });
            modelBuilder.Entity<Book>(e =>
            {
                e.ToTable("books");
                e.HasKey(e => e.IdBook);
                e.Property(e => e.IdBook)
                .ValueGeneratedOnAdd();
                e.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);
                e.Property(e => e.Image)
                .HasMaxLength(500);
                e.Property(e => e.SubTitle)
                .HasMaxLength(500);
                e.Property(e => e.Description)
                .HasMaxLength(1000);
                e.HasOne(e => e.Author)
                .WithMany(e => e.Book)
                .HasForeignKey(e => e.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
                e.HasOne(e => e.Genre)
                .WithMany(e => e.Book)
                .HasForeignKey(e => e.GenreId)
                .OnDelete(DeleteBehavior.Restrict);




            });
            modelBuilder.Entity<Rating>(e =>
            {
                e.ToTable("ratings");
                e.HasKey(e => e.IdRate);
                e.Property(e => e.IdRate)
                .ValueGeneratedOnAdd();
                e.HasOne(e => e.Book)
                .WithMany(e => e.Rating)
                .HasForeignKey(e => e.BookId)
                .OnDelete(DeleteBehavior.Restrict);
                e.HasOne(e => e.User)
                .WithMany(e => e.Rating)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);



            });

            modelBuilder.Entity<BorrowingItems>(e =>
            {
                e.ToTable("borrowing_items");
                e.HasKey(e => e.IDitem);
                e.Property(e => e.IDitem)
                .ValueGeneratedOnAdd();
                e.HasOne(e => e.Book)
                .WithMany(e => e.BorrowingItems)
                .HasForeignKey(e => e.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<Borrowing>(e =>
            {
                e.ToTable("borrowings");
                e.HasKey(e => e.IdBor);
                e.Property(e => e.IdBor)
                .ValueGeneratedOnAdd();
                e.HasOne(e => e.User)
                .WithMany(e => e.Borrowing)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("users");
                e.HasKey(e => e.IdUser);
                e.Property(e => e.IdUser)
                .ValueGeneratedOnAdd();
                e.Property(e => e.NameUser)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);
                e.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(true);
                e.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(true);


            });
        }
    }
}
