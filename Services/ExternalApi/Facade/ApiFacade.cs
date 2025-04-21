namespace Services.ExternalApi.Facade;

public class ApiFacade : IApiFacade
{
    public IAuthApiService AuthApiService { get; set; }
    public IAdminApiService AdminApiService { get; set; }

    public ISuppliersApiService SuppliersApiService { get; set; }
    public ISupplyOrderStatusApiService SupplyOrderStatusApiService { get; set; }
    public ILocationApiService LocationApiService { get; set; }
    public IPositionApiService PositionApiService { get; set; }
    public IClubApiService ClubApiService { get; set; }
    public IEmployeeApiService EmployeeApiService { get; set; }
    public ICategoryApiService CategoryApiService { get; set; }
    public IBrandApiService BrandApiService { get; set; }
    public ITypeApiService TypeApiService { get; set; }
    public IEquipmentApiService EquipmentApiService { get; set; }
    public IOrderStatusApiService OrderStatusApiService { get; set; }
    public IClientApiService ClientApiService { get; set; }
    public IClubOffersApiService ClubOffersApiService { get; set; }
    public ISupplyOrdersApiService SupplyOrdersApiService { get; set; }
    public IOrdersApiService OrdersApiService { get; set; }
    public IMatchApiService MatchApiService { get; set; }
    public ISuppliedEquipmentApiService SuppliedEquipmentApiService { get; set; }
    public IAvailableEquipmentApiService AvailableEquipmentApiService { get; set; }
    public IOrderDetailsApiService OrderDetailsApiService { get; set; }
    public IProductPlacementApiService ProductPlacementApiService { get; set; }

    public ApiFacade(
        IAuthApiService authApiService,
        IAdminApiService adminApiService,

        ISuppliersApiService suppliersApiService,
        ISupplyOrderStatusApiService supplyOrderStatusApiService,
        ILocationApiService locationApiService,
        IPositionApiService positionApiService,
        IClubApiService clubApiService,
        IEmployeeApiService employeeApiService,
        ICategoryApiService categoryApiService,
        IBrandApiService brandApiService,
        ITypeApiService typeApiService,
        IEquipmentApiService equipmentApiService,
        IOrderStatusApiService orderStatusApiService,
        IClientApiService clientApiService,
        IClubOffersApiService clubOffersApiService,
        ISupplyOrdersApiService supplyOrdersApiService,
        IOrdersApiService ordersApiService,
        IMatchApiService matchApiService,
        ISuppliedEquipmentApiService suppliedEquipmentApiService,
        IAvailableEquipmentApiService availableEquipmentApiService,
        IOrderDetailsApiService orderDetailsApiService,
        IProductPlacementApiService productPlacementApiService)
    {
        AuthApiService = authApiService;
        AdminApiService = adminApiService;

        SuppliersApiService = suppliersApiService;
        SupplyOrderStatusApiService = supplyOrderStatusApiService;
        LocationApiService = locationApiService;
        PositionApiService = positionApiService;
        ClubApiService = clubApiService;
        EmployeeApiService = employeeApiService;
        CategoryApiService = categoryApiService;
        BrandApiService = brandApiService;
        TypeApiService = typeApiService;
        EquipmentApiService = equipmentApiService;
        OrderStatusApiService = orderStatusApiService;
        ClientApiService = clientApiService;
        ClubOffersApiService = clubOffersApiService;
        SupplyOrdersApiService = supplyOrdersApiService;
        OrdersApiService = ordersApiService;
        MatchApiService = matchApiService;
        SuppliedEquipmentApiService = suppliedEquipmentApiService;
        AvailableEquipmentApiService = availableEquipmentApiService;
        OrderDetailsApiService = orderDetailsApiService;
        ProductPlacementApiService = productPlacementApiService;
    }
}