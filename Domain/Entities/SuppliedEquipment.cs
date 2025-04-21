using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("SuppliedEquipment")]
public class SuppliedEquipment
{
    [Key]
    public int supplied_equipment_id { get; set; }

    public int supply_order_id { get; set; }

    public int equipment_id { get; set; }

    public int quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
