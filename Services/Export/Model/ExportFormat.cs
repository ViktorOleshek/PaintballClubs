using System.ComponentModel.DataAnnotations;

namespace Services.Export.Model;

public enum ExportFormat
{
    [Display(Name = "CSV")]
    CSV,

    [Display(Name = "JSON")]
    JSON
}