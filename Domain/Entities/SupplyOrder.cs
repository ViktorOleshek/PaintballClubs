using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class SupplyOrder
{
    [Key]
    public int supply_order_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime order_date { get; set; }

    public int supplier_id { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal total_amount { get; set; }

    public int status_id { get; set; }

    public int employee_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
