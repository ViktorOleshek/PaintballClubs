using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Type")]
public class Type
{
    [Key]
    public int type_id { get; set; }

    [StringLength(100)]
    public string type_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
