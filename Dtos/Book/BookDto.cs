namespace ThuVierApi.Dtos.Book
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int? AuthorId { get; set; }
        public int? GenreId { get; set; }
        public int? PublishingYear { get; set; }
        public int? QuantityInStock { get; set; }
    }
}
