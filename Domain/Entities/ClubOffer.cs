using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class ClubOffer
{
    [Key]
    public int offer_id { get; set; }

    [StringLength(255)]
    public string name { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal price { get; set; }

    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
