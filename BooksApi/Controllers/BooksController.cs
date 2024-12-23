using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Books.Common;

namespace BooksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : Controller
{
    [HttpGet]
    public IActionResult List()
    {
        var books = BooksData.GetAllBooks()
            .OrderBy(x => x.Id);
             
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        if (String.IsNullOrWhiteSpace(id))
            return BadRequest();

        // use id = "ERROR" (case insensitive)
        // to simulate an internal server error

        switch(id.Trim().ToUpper())
        {
            case "ERROR":
            case "500":
                return StatusCode(StatusCodes.Status500InternalServerError);
                break;

            case "AUTH":
            case "401":
                return Unauthorized();
                break;
        }

        if (id.Trim().Equals("ERROR", StringComparison.OrdinalIgnoreCase))
            return StatusCode(StatusCodes.Status500InternalServerError);

        var book = BooksData
                    .GetAllBooks()
                    .FirstOrDefault(x => x.Id == id);

        if (book is not null)
            return Ok(book);

        return NotFound();

    }

    
}