using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Auth;

public class LoginModel
{
    [Required(ErrorMessage = "Логін є обов'язковим.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Логін має містити від 3 до 50 символів.")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Логін може містити лише літери, цифри та підкреслення.")]
    public string login { get; set; } = string.Empty;

    [Required(ErrorMessage = "Пароль є обов'язковим.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль має містити щонайменше 6 символів.")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,100}$",
        ErrorMessage = "Пароль має містити принаймні одну велику літеру, одну цифру та один спеціальний символ.")]
    public string password { get; set; } = string.Empty;
}
