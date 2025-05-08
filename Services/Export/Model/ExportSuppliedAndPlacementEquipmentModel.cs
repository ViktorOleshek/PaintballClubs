namespace Services.Export.Model;

public class ExportSupplyOrderModel
{
    public string OrderNumber { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public string SupplierName { get; set; } = string.Empty;
    public string StatusName { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
    public List<ExportSuppliedEquipmentModel> SuppliedEquipment { get; set; } = new();
}

public class ExportSuppliedEquipmentModel
{
    public string EquipmentName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string TypeName { get; set; } = string.Empty;
    public string BrandName { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public List<ExportPlacementModel> Placements { get; set; } = new();
}

public class ExportPlacementModel
{
    public DateTime PlacementDate { get; set; }
    public int Quantity { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public string ClubName { get; set; } = string.Empty;
}