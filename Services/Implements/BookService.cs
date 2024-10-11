using ThuVienMVC.Models;
using ThuVierApi.DbContexts;
using ThuVierApi.Dtos.Book;
using ThuVierApi.Services.Interfaces;


namespace ThuVierApi.Services.Implements
{
    public class BookService : IBook
    {
        private readonly ConText _context;
        public BookService(ConText context)
        {
            _context = context;
        }
        public void Create(BookDto input)
        {
            var book = new Book
            {
                Title = input.Title,
                Image = input.Image,
                SubTitle = input.SubTitle,
                Description = input.Description,
                PublishingYear = input.PublishingYear,
                QuantityInStock = input.QuantityInStock,
                Createdat = DateTime.Now,
            };
            _context.books.Add(book);
            _context.SaveChangesAsync();

        }

        public void Delete(int id)
        {
            var book =  _context.books.SingleOrDefault(e => e.IdBook == id);
            if (book == null)
            {
                throw new KeyNotFoundException("Book not found");
            }

            _context.books.Remove(book);
            _context.SaveChangesAsync();
        }

        public List<Book> GetAll()
        {
            return _context.books.ToList();
        }

        public void Update(UpdateBookDto input)
        {
            var book =  _context.books.SingleOrDefault(e=> e.IdBook==input.IdBook);
            book.Title = input.Title;
            book.Image = input.Image;
            book.SubTitle = input.SubTitle;
            book.Description = input.Description;
            book.AuthorId = input.AuthorId;
            book.GenreId = input.GenreId;
            book.PublishingYear = input.PublishingYear;
            book.QuantityInStock = input.QuantityInStock;
            book.Updatedat = DateTime.Now;  

            _context.books.Update(book);
             _context.SaveChangesAsync();

        }
    }
}
