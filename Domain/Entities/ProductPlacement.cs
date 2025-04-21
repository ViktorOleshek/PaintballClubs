using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("ProductPlacement")]
public class ProductPlacement
{
    [Key]
    public int placement_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime placement_date { get; set; }

    public int quantity { get; set; }

    public int employee_id { get; set; }

    public int available_id { get; set; }

    public int supplied_equipment_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
