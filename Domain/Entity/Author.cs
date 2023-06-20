using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Author
{
    public int AuthorId { get; set; }
    [MaxLength(100)]
    public int Ssn { get; set; }
    [MaxLength(50)]
    public String LastName { get; set; }
    [MaxLength(50)]
    public String FirstName { get; set; }
    [MaxLength(50)]
    public String Phone { get; set; }
    [MaxLength(100)]
    public String Address { get; set; }
    [MaxLength(50)]
    public String City { get; set; }
    [MaxLength(50)]
    public String State { get; set; }
    [MaxLength(50)]
    public int Zip { get; set; }
    public ICollection<BookAuthor> Bookauthors { get; set; }
}