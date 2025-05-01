using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class ClubOffer
{
    [Key]
    [Display(Name = "Ідентифікатор пропозиції")]
    public int offer_id { get; set; }

    [Required(ErrorMessage = "Назва є обов'язковою")]
    [StringLength(255, ErrorMessage = "Назва не може перевищувати 255 символів")]
    [Display(Name = "Назва пропозиції")]
    public string name { get; set; } = null!;

    [Required(ErrorMessage = "Ціна є обов'язковою")]
    [Range(0.01, 9999999.99, ErrorMessage = "Ціна повинна бути більшою за 0 і не перевищувати 9,999,999.99")]
    [Column(TypeName = "decimal(10, 2)")]
    [Display(Name = "Ціна")]
    public decimal price { get; set; }

    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "Дата створення")] 
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "Дата оновлення")] 
    public DateTime? UpdateDatetime { get; set; }
}
