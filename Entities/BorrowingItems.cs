namespace ThuVienMVC.Models
{
    public class BorrowingItems : CRUDbooks
    {
        public int IDitem { get; set; }
        public int Quantity {  get; set; }
        public int BorrowingId { get; set; }
        public int BookId { get; set; }

        public Book Book { get; set; }
        public Borrowing Borrowing {  get; set; }
        
    }
}
