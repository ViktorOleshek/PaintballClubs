using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Club")]
public class Club
{
    [Key]
    public int club_id { get; set; }

    [Required(ErrorMessage = "Назва клубу є обов'язковою")]
    [StringLength(255, ErrorMessage = "Назва не може перевищувати 255 символів")]
    [Display(Name = "Назва клубу")]
    public string name { get; set; } = null!;

    [StringLength(255, ErrorMessage = "Адреса не може перевищувати 255 символів")]
    [Display(Name = "Адреса")]
    public string? address { get; set; }

    [StringLength(100, ErrorMessage = "Телефон не може перевищувати 100 символів")]
    [RegularExpression(@"^[0-9+\-\s()]*$", ErrorMessage = "Телефон може містити лише цифри та символи +, -, (), пробіли")]
    [Display(Name = "Телефон")] 
    public string? phone_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
