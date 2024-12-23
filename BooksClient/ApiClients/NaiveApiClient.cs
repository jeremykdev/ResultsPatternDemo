using System.Net.Http.Json;
using Books.Common;

namespace BooksClient.ApiClients;

public class NaiveApiClient : BaseApiClient
{
    public async Task<Book[]?> GetAllBooks()
    {
        try
        {
            Uri uri = this.BuildUriForGetAllBooks();
            Book[]? books = await this._httpClient.GetFromJsonAsync<Book[]>(uri);
            return books;
        }
        catch (Exception ex) 
        {
            Logger.Log(ex.Message);
            return null; 
        }
    }

    public async Task<Book?> GetBookById(string id)
    {
        try
        {
            Uri uri = this.BuildUriForGetById(id);
            Book? book = await this._httpClient.GetFromJsonAsync<Book>(uri);
            return book;
        }
        catch (Exception ex)
        {
            Logger.Log(ex.Message);
            return null;
        }
    }
}
