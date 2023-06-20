using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

public class BookAuthor
{
    [Key]
    public int AuthorId { get; set; }
    public int Isbn { get; set; }
    public int AuthorOrder { get; set; }
    public String RoyaltyShare { get; set; }
    public Author Author { get; set; }
    [ForeignKey("Isbn")]
    public Book Book { get; set; }
}