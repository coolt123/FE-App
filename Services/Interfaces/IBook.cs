using ThuVienMVC.Models;
using ThuVierApi.Dtos.Book;
namespace ThuVierApi.Services.Interfaces
{
    public interface IBook
    {
        List<Book> GetAll();
        void Create(BookDto input);
        void Update(UpdateBookDto input);
        void Delete(int id);
    }
}
