using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Employee")]
public class Employee
{
    [Key]
    public int employee_id { get; set; }

    [StringLength(100)]
    public string first_name { get; set; } = null!;

    [StringLength(100)]
    public string last_name { get; set; } = null!;

    public int position_id { get; set; }

    public int club_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
