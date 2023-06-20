namespace Domain.Dtos;

public class BookBaseDto
{
    public string Isbn { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public int PublisherId { get; set; }

    public decimal YtdSales { get; set; }
    public DateTime PublisherDate { get; set; }
    public decimal Advance { get; set; }
}

public class AddBookDto : BookBaseDto
{
    
}