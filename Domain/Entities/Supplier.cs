using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Supplier
{
    [Key]
    public int supplier_id { get; set; }

    [StringLength(255)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    public string? phone_number { get; set; }

    [StringLength(255)]
    public string? email { get; set; }

    [StringLength(255)]
    public string? address { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
