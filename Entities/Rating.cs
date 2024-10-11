namespace ThuVienMVC.Models
{
    public class Rating : CRUDbooks
    {
        public int IdRate { get; set; }
        public int Star { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }

    }
}
