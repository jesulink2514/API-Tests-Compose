namespace sample_api.Models
{
    public class BookService
    {
        private List<Book> _books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Book 1",
                Price = 59.99M
            },
            new Book
            {
                Id = 2,
                Title = "Book 2",
                Price = 14.99M
            },
            new Book
            {
                Id = 3,
                Title = "Book 3",
                Price = 9.99M
            },
            new Book
            {
                Id = 4,
                Title = "Book 4",
                Price = 19.99M
            }
        };

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }


        public Book GetById(int id)
        {
            return _books.FirstOrDefault(x => x.Id == id);
        }

    }
}