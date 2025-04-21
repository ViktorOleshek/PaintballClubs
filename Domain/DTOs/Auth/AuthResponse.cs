namespace Domain.DTOs.Auth;

public class AuthResponse
{
    public string name { get; set; }
    public string surname { get; set; }
    public string role { get; set; }
    public string token { get; set; }
}