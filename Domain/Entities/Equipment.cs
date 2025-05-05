using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Equipment
{
    [Key]
    [Display(Name = "Ідентифікатор обладнання")]
    public int equipment_id { get; set; }

    [Required(ErrorMessage = "Назва є обов'язковою")]
    [StringLength(255, ErrorMessage = "Назва не може перевищувати 255 символів")]
    [Display(Name = "Назва обладнання")]
    public string name { get; set; } = null!;

    [Display(Name = "Опис")]
    public string? description { get; set; }

    [Required(ErrorMessage = "Бренд є обов'язковим")]
    [Display(Name = "Бренд")]
    public int brand_id { get; set; }

    [Required(ErrorMessage = "Категорія є обов'язковою")]
    [Display(Name = "Категорія")]
    public int category_id { get; set; }

    [Required(ErrorMessage = "Тип є обов'язковим")]
    [Display(Name = "Тип")]
    public int type_id { get; set; }

    [Required(ErrorMessage = "Модель є обов'язковою")]
    [StringLength(100, ErrorMessage = "Модель не може перевищувати 100 символів")]
    [Display(Name = "Модель")]
    public string? model { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "Дата створення")]
    public DateTime? CreateDatetime { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "Дата оновлення")]
    public DateTime? UpdateDatetime { get; set; }
}
