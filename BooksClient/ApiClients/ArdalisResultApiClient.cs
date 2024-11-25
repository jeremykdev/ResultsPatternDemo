using Ardalis.Result;
using Books.Common;
using System.Net;
using System.Net.Http.Json;

namespace BooksClient.ApiClients;

public class ArdalisResultApiClient : BaseApiClient
{
    public async Task<Result<Book[]?>> GetAllBooks()
    {
        try
        {
            Uri uri = this.BuildUriForGetAllBooks();
            var books = await this._httpClient.GetFromJsonAsync<Book[]>(uri);
            return books;
        }
        catch (HttpRequestException ex)
        {
            return this.GetResultFromHttpStatusCode(ex.StatusCode);
        }
        catch (Exception ex)
        {
            Logger.Log(ex.Message);
            return Result.Error(ex.Message);
        }
    }

    public async Task<Result<Book?>> GetBookById(string id)
    {
        try
        {
            Uri uri = this.BuildUriForGetById(id);
            var book = await this._httpClient.GetFromJsonAsync<Book>(uri);
            return book;
        }
        catch (HttpRequestException ex)
        {
            return this.GetResultFromHttpStatusCode(ex.StatusCode);
        }
        catch (Exception ex)
        {
            Logger.Log(ex.Message);
            return Result.Error(ex.Message);
        }
    }

    protected Result GetResultFromHttpStatusCode(HttpStatusCode? statusCode) =>
        statusCode switch
        {
            HttpStatusCode.NotFound => Result.NotFound(),
            HttpStatusCode.InternalServerError => Result.Error(),
            HttpStatusCode.Unauthorized => Result.Unauthorized(),
            _ => Result.Error(),
        };
    

            

}
