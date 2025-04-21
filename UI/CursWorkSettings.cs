using System.ComponentModel.DataAnnotations;

namespace UI;

public class CursWorkSettings
{
    public const string ConfigurationSection = "CursWorkApi";

    [Required, Url]
    public string BaseAddress { get; set; } = string.Empty;
}