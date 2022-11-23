namespace sample_api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BookId {get;set;}
        public string Title { get; set; }
        public decimal Amount {get;set;}
        public DateTime CreatedDate { get; set; }        
    }
}