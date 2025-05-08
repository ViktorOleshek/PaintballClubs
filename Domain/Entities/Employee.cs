using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("Employee")]
public class Employee
{
    [Key]
    public int employee_id { get; set; }

    [Required(ErrorMessage = "Ім'я є обов'язковим")]
    [StringLength(100, ErrorMessage = "Ім'я не може перевищувати 100 символів")]
    [Display(Name = "Ім'я")]
    public string first_name { get; set; } = null!;

    [Required(ErrorMessage = "Прізвище є обов'язковим")]
    [StringLength(100, ErrorMessage = "Прізвище не може перевищувати 100 символів")]
    [Display(Name = "Прізвище")]
    public string last_name { get; set; } = null!;
    [Required(ErrorMessage = "Логін є обов'язковим")]
    [StringLength(100, ErrorMessage = "Логін не може перевищувати 100 символів")]
    [Display(Name = "Логін")]
    public string login { get; set; } = null!;

    [Required(ErrorMessage = "Пароль є обов'язковим")]
    [StringLength(100, ErrorMessage = "Пароль не може перевищувати 100 символів")]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*(),.?\"":{}|<>]).{8,30}$",
        ErrorMessage = "Пароль має містити від 8 до 30 символів, принаймні одну літеру, одну цифру та один спеціальний символ")]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string password { get; set; } = null!;

    [Required(ErrorMessage = "Посада є обов'язковою")]
    [Display(Name = "Посада")]
    public int position_id { get; set; }

    public int club_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDatetime { get; set; }
}
