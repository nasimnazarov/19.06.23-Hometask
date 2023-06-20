using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Book
{
    [Key]
    public int Isbn { get; set; }
    [MaxLength(50)]
    public string Title { get; set; }
    [MaxLength(50)]
    public string Type { get; set; }
    public int PublisherId { get; set; }
    public decimal Price { get; set; }
    public String Advance { get; set; }
    public DateTime PublishedDate { get; set; }
    public virtual Publisher Publisher { get; set; }
    public virtual ICollection<BookEditor> BookEditors { get; set; }
    public virtual ICollection<BookAuthor> Bookauthors { get; set; }
}