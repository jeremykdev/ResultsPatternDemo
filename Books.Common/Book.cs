namespace Books.Common;

public class Book
{
    public string Id { get; set; } = String.Empty;

    public string Title { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string Type { get; set; } = String.Empty;

    public decimal Price { get; set; } = 0;

    public string Author {  get; set; } = String.Empty;
}
