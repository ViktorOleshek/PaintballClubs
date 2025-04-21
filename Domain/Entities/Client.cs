using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Client")]
public class Client
{
    [Key]
    public int client_id { get; set; }

    [StringLength(100)]
    public string first_name { get; set; } = null!;

    [StringLength(100)]
    public string last_name { get; set; } = null!;

    public DateOnly? birth_date { get; set; }

    [StringLength(100)]
    public string? phone_number { get; set; }

    [StringLength(255)]
    public string? email { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
