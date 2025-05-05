using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Supplier
{
    [Key]
    public int supplier_id { get; set; }

    [Required(ErrorMessage = "Назва є обов'язковою")]
    [StringLength(255, ErrorMessage = "Назва не може перевищувати 255 символів")]
    [Display(Name = "Назва")]
    public string name { get; set; } = null!;

    [Required(ErrorMessage = "Номер телефону є обов'язковим")]
    [StringLength(100, ErrorMessage = "Номер телефону не може перевищувати 100 символів")]
    [Display(Name = "Номер телефону")]
    [Phone(ErrorMessage = "Некоректний формат номера телефону")]
    public string? phone_number { get; set; }

    [Required(ErrorMessage = "Електронна пошта є обов'язковою")]
    [StringLength(255, ErrorMessage = "Email не може перевищувати 255 символів")]
    [EmailAddress(ErrorMessage = "Некоректний формат електронної пошти")]
    [RegularExpression(@"^.+@..+\..+$", ErrorMessage = "Електронна пошта має бути у форматі, подібному до example@domain.com")]
    [Display(Name = "Email")]
    public string? email { get; set; }

    [Required(ErrorMessage = "Адреса є обов'язковою")]
    [StringLength(255, ErrorMessage = "Адреса не може перевищувати 255 символів")]
    [Display(Name = "Адреса")]
    public string? address { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "Дата створення")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "Дата оновлення")]
    public DateTime? UpdateDatetime { get; set; }
}
