using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Order
{
    [Key]
    public int order_id { get; set; }

    [StringLength(50)]
    public string order_number { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? total_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? event_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? order_time { get; set; }

    public int? client_id { get; set; }

    public int employee_id { get; set; }

    public int offer_id { get; set; }

    public int status_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
