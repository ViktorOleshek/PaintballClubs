using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Auth;

public class LoginModel
{
    [Required(ErrorMessage = "Login is required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Login must be between 3 and 50 characters.")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Login can only contain letters, numbers, and underscores.")]
    public string login { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,100}$",
        ErrorMessage = "Password must contain at least one uppercase letter, one number, and one special character.")]
    public string password { get; set; } = string.Empty;
}