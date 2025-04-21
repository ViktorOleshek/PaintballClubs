using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Match")]
public class Match
{
    [Key]
    public int match_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime event_date { get; set; }

    public int? location_id { get; set; }

    public int participant_count { get; set; }

    public string? description { get; set; }

    public int order_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
