using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Equipment
{
    [Key]
    public int equipment_id { get; set; }

    [StringLength(255)]
    public string name { get; set; } = null!;

    public string? description { get; set; }

    public int brand_id { get; set; }

    public int category_id { get; set; }

    public int type_id { get; set; }

    [StringLength(100)]
    public string? model { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
