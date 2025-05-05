using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("AvailableEquipment")]
public class AvailableEquipment
{
    [Key]
    public int available_id { get; set; }

    [Required(ErrorMessage = "Кількість є обов'язковою")]
    [Range(0, 100000, ErrorMessage = "Кількість повинна бути від 0 до 100000")]
    [Display(Name = "Доступна кількість")]
    public int available_quantity { get; set; }

    [Required(ErrorMessage = "Ціна оренди є обов'язковою")]
    [Range(0, 100000, ErrorMessage = "Ціна повинна бути від 0 до 100000")]
    [Display(Name = "Ціна оренди")]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal rental_price { get; set; }

    [Required(ErrorMessage = "Обладнання є обов'язковим")]
    [Display(Name = "Обладнання")]
    public int equipment_id { get; set; }

    public int club_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
