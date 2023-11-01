#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace Models;
public class Tour
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid OperatorId { get; set; }
    public Guid HotelId { get; set; }
    public int Days { get; set; }

    [ForeignKey("OperatorId")]
    public virtual Operator Operator { get; set; }
    [ForeignKey("HotelId")]
    public virtual Hotel Hotel { get; set; }
}
