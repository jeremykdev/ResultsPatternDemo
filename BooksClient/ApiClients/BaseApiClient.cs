using Flurl;

namespace BooksClient.ApiClients;

public abstract class BaseApiClient
{
    private string baseUrl = "http://localhost:5135/api/Books";

    protected HttpClient _httpClient;

    protected BaseApiClient()
    {
        this._httpClient = new HttpClient();
    }

    protected Uri BuildUriForGetAllBooks() => 
        new Uri(this.baseUrl);

    protected Uri BuildUriForGetById(string id) => 
        baseUrl.AppendPathSegment(id ?? " ").ToUri();
           
}
