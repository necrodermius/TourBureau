#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace Models;
public class Statement
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid TourId { get; set; }

    [ForeignKey("ClientId")]
    public virtual Client Client { get; set; }
    [ForeignKey("TourId")]
    public virtual Tour Tour { get; set;}
}
