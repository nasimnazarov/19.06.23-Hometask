namespace Domain.Entity;

public class Editor
{
    public int EditorId { get; set; }
    public int Ssn { get; set; }
    public String LastName { get; set; }
    public String FirstName { get; set; }
    public String Phone { get; set; }
    public String EditorPosition { get; set; }
    public decimal Salary { get; set; }
    public ICollection<BookEditor> Bookeditors { get; set; }
}