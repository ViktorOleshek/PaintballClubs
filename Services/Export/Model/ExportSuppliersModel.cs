using System.ComponentModel.DataAnnotations;

namespace Services.Export.Model;

public class ExportSuppliersModel
{
    [Display(Name = "Назва постачальника")]
    public bool IncludeName { get; set; } = true;

    [Display(Name = "Телефон")]
    public bool IncludePhone { get; set; } = true;

    [Display(Name = "Email")]
    public bool IncludeEmail { get; set; } = true;

    [Display(Name = "Адреса")]
    public bool IncludeAddress { get; set; } = true;

    [Display(Name = "Загальна кількість обладнання")]
    public bool IncludeEquipmentCount { get; set; } = true;

    [Display(Name = "Дата останньої поставки")]
    public bool IncludeLastSupplyDate { get; set; } = true;

    [Display(Name = "Формат файлу")]
    public ExportFormat FileFormat { get; set; } = ExportFormat.CSV;

    [Display(Name = "Застосувати поточні фільтри")]
    public bool ApplyCurrentFilters { get; set; } = true;
}
