using Microsoft.AspNetCore.Mvc;
using sample_api.Models;

namespace sample_api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController: ControllerBase
{
    private readonly BookService bookService;

    public BooksController(BookService bookService)
    {
        this.bookService = bookService;
    }
   
    //return sample list of books
    [HttpGet(Name = "GetBooks")]
    public IEnumerable<Book> Get()
    {
        //return sample list of Book
        return bookService.GetAll();
    }

    //return a single book by id
    [HttpGet("{id}", Name = "GetBookById")]
    public Book Get(int id)
    {
        return bookService.GetById(id);
    }

}