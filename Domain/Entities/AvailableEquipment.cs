using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("AvailableEquipment")]
public class AvailableEquipment
{
    [Key]
    public int available_id { get; set; }

    public int available_quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal rental_price { get; set; }

    public int equipment_id { get; set; }

    public int club_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
