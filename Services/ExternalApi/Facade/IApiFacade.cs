namespace Services.ExternalApi.Facade;

public interface IApiFacade
{
    IAuthApiService AuthApiService { get; set; }
    IAdminApiService AdminApiService { get; set; }

    ISuppliersApiService SuppliersApiService { get; set; }
    ISupplyOrderStatusApiService SupplyOrderStatusApiService { get; set; }
    ILocationApiService LocationApiService { get; set; }
    IPositionApiService PositionApiService { get; set; }
    IClubApiService ClubApiService { get; set; }
    IEmployeeApiService EmployeeApiService { get; set; }
    ICategoryApiService CategoryApiService { get; set; }
    IBrandApiService BrandApiService { get; set; }
    ITypeApiService TypeApiService { get; set; }
    IEquipmentApiService EquipmentApiService { get; set; }
    IOrderStatusApiService OrderStatusApiService { get; set; }
    IClientApiService ClientApiService { get; set; }
    IClubOffersApiService ClubOffersApiService { get; set; }
    ISupplyOrdersApiService SupplyOrdersApiService { get; set; }
    IOrdersApiService OrdersApiService { get; set; }
    IMatchApiService MatchApiService { get; set; }
    ISuppliedEquipmentApiService SuppliedEquipmentApiService { get; set; }
    IAvailableEquipmentApiService AvailableEquipmentApiService { get; set; }
    IOrderDetailsApiService OrderDetailsApiService { get; set; }
    IProductPlacementApiService ProductPlacementApiService { get; set; }
}