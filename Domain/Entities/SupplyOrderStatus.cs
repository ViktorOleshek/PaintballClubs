using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("SupplyOrderStatus")]
public class SupplyOrderStatus
{
    [Key]
    public int status_id { get; set; }

    [StringLength(50)]
    public string status_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
