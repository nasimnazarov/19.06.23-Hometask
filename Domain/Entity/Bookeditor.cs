using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;

namespace Domain.Entity;

public class BookEditor
{
    //[Key]
    public int EditorId { get; set; }
    public int Isbn { get; set; }
    [ForeignKey("Isbn")]
    public Book Book { get; set; }
    public Editor Editor { get; set; }
}