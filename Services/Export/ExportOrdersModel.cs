namespace Services.Export;

public class ExportOrdersModel
{
    public bool IncludeOrderNumber { get; set; } = true;
    public bool IncludeOrderDate { get; set; } = true;
    public bool IncludeEventDate { get; set; } = true;
    public bool IncludeStatus { get; set; } = true;
    public bool IncludeClient { get; set; } = true;
    public bool IncludeEmployee { get; set; } = true;
    public bool IncludeClub { get; set; } = true;
    public bool IncludeOffer { get; set; } = true;
    public bool IncludeTotalAmount { get; set; } = true;
    public bool IncludeEquipment { get; set; } = false;
    public bool IncludeMatchDetails { get; set; } = false;
}