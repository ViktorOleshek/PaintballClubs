using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Brand")]
public class Brand
{
    [Key]
    public int brand_id { get; set; }

    [StringLength(100)]
    public string brand_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
