namespace ThuVienMVC.Models
{
    public class Borrowing : CRUDbooks
    {
        public int IdBor {  get; set; }
        public int UserId { get; set; }
        public DateTime Startat { get; set; }
        public DateTime Endat { get; set; }
        public DateTime ActualEndAt { get; set; }
        public ICollection<BorrowingItems> BorrowingItems { get; set; }
        public User User { get; set; }

    }
}
