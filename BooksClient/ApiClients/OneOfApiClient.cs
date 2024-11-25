using OneOf;
using Books.Common;
using System.Net;
using System.Net.Http.Json;
using OneOf.Types;


namespace BooksClient.ApiClients;

public class OneOfApiClient : BaseApiClient
{
    public async Task<OneOf<Book[]?, NotFound, Error>> GetAllBooks()
    {
        try
        {
            Uri uri = this.BuildUriForGetAllBooks();
            var books = await this._httpClient.GetFromJsonAsync<Book[]>(uri);
            return books;
        }
        catch (HttpRequestException ex)
        {
            if (ex.StatusCode == HttpStatusCode.NotFound)
                return new NotFound();

            return new Error();
        }
        catch (Exception ex)
        {
            Logger.Log(ex.Message);
            return new Error();
        }
    }

    public async Task<OneOf<Book?, NotFound, Error>> GetBookById(string id)
    {
        try
        {
            Uri uri = this.BuildUriForGetById(id);
            var book = await this._httpClient.GetFromJsonAsync<Book>(uri);
            return book;
        }
        catch (HttpRequestException ex)
        {
            if (ex.StatusCode == HttpStatusCode.NotFound)
                return new NotFound();

            return new Error();
        }
        catch (Exception ex)
        {
            Logger.Log(ex.Message);
            return new Error();
        }
    }
}
