namespace ThuVienMVC.Models
{
    public class Genre : CRUDbooks
    {
        public int IdGenres {  get; set; }
        public int NameGenres {  get; set; }
        public ICollection<Book> Book {  get; set; }
    }
}
