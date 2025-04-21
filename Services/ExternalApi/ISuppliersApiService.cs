using Domain.Entities;
using Refit;
using Type = Domain.Entities.Type;

namespace Services.ExternalApi;

public interface ISuppliersApiService
{
    [Get("/suppliers")]
    Task<IApiResponse<IEnumerable<Supplier>>> Get();

    [Get("/suppliers/{id}")]
    Task<IApiResponse<Supplier>> Get(int id);

    [Post("/suppliers")]
    Task<IApiResponse<Supplier>> Create([Body] Supplier entity);

    [Put("/suppliers/{id}")]
    Task<IApiResponse> Update(int id, [Body] Supplier entity);

    [Delete("/suppliers/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface ISupplyOrderStatusApiService
{
    [Get("/supplyorderstatus")]
    Task<IApiResponse<IEnumerable<SupplyOrderStatus>>> Get();

    [Get("/supplyorderstatus/{id}")]
    Task<IApiResponse<SupplyOrderStatus>> Get(int id);

    [Post("/supplyorderstatus")]
    Task<IApiResponse<SupplyOrderStatus>> Create([Body] SupplyOrderStatus entity);

    [Put("/supplyorderstatus/{id}")]
    Task<IApiResponse> Update(int id, [Body] SupplyOrderStatus entity);

    [Delete("/supplyorderstatus/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface ILocationApiService
{
    [Get("/location")]
    Task<IApiResponse<IEnumerable<Location>>> Get();

    [Get("/location/{id}")]
    Task<IApiResponse<Location>> Get(int id);

    [Post("/location")]
    Task<IApiResponse<Location>> Create([Body] Location entity);

    [Put("/location/{id}")]
    Task<IApiResponse> Update(int id, [Body] Location entity);

    [Delete("/location/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IPositionApiService
{
    [Get("/position")]
    Task<IApiResponse<IEnumerable<Position>>> Get();

    [Get("/position/{id}")]
    Task<IApiResponse<Position>> Get(int id);

    [Post("/position")]
    Task<IApiResponse<Position>> Create([Body] Position entity);

    [Put("/position/{id}")]
    Task<IApiResponse> Update(int id, [Body] Position entity);

    [Delete("/position/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IClubApiService
{
    [Get("/club")]
    Task<IApiResponse<IEnumerable<Club>>> Get();

    [Get("/club/{id}")]
    Task<IApiResponse<Club>> Get(int id);

    [Post("/club")]
    Task<IApiResponse<Club>> Create([Body] Club entity);

    [Put("/club/{id}")]
    Task<IApiResponse> Update(int id, [Body] Club entity);

    [Delete("/club/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IEmployeeApiService
{
    [Get("/employee")]
    Task<IApiResponse<IEnumerable<Employee>>> Get();

    [Get("/employee/{id}")]
    Task<IApiResponse<Employee>> Get(int id);

    [Post("/employee")]
    Task<IApiResponse<Employee>> Create([Body] Employee entity);

    [Put("/employee/{id}")]
    Task<IApiResponse> Update(int id, [Body] Employee entity);

    [Delete("/employee/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface ICategoryApiService
{
    [Get("/category")]
    Task<IApiResponse<IEnumerable<Category>>> Get();

    [Get("/category/{id}")]
    Task<IApiResponse<Category>> Get(int id);

    [Post("/category")]
    Task<IApiResponse<Category>> Create([Body] Category entity);

    [Put("/category/{id}")]
    Task<IApiResponse> Update(int id, [Body] Category entity);

    [Delete("/category/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IBrandApiService
{
    [Get("/brand")]
    Task<IApiResponse<IEnumerable<Brand>>> Get();

    [Get("/brand/{id}")]
    Task<IApiResponse<Brand>> Get(int id);

    [Post("/brand")]
    Task<IApiResponse<Brand>> Create([Body] Brand entity);

    [Put("/brand/{id}")]
    Task<IApiResponse> Update(int id, [Body] Brand entity);

    [Delete("/brand/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface ITypeApiService
{
    [Get("/type")]
    Task<IApiResponse<IEnumerable<Type>>> Get();

    [Get("/type/{id}")]
    Task<IApiResponse<Type>> Get(int id);

    [Post("/type")]
    Task<IApiResponse<Type>> Create([Body] Type entity);

    [Put("/type/{id}")]
    Task<IApiResponse> Update(int id, [Body] Type entity);

    [Delete("/type/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IEquipmentApiService
{
    [Get("/equipment")]
    Task<IApiResponse<IEnumerable<Equipment>>> Get();

    [Get("/equipment/{id}")]
    Task<IApiResponse<Equipment>> Get(int id);

    [Post("/equipment")]
    Task<IApiResponse<Equipment>> Create([Body] Equipment entity);

    [Put("/equipment/{id}")]
    Task<IApiResponse> Update(int id, [Body] Equipment entity);

    [Delete("/equipment/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IOrderStatusApiService
{
    [Get("/orderstatus")]
    Task<IApiResponse<IEnumerable<OrderStatus>>> Get();

    [Get("/orderstatus/{id}")]
    Task<IApiResponse<OrderStatus>> Get(int id);

    [Post("/orderstatus")]
    Task<IApiResponse<OrderStatus>> Create([Body] OrderStatus entity);

    [Put("/orderstatus/{id}")]
    Task<IApiResponse> Update(int id, [Body] OrderStatus entity);

    [Delete("/orderstatus/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IClientApiService
{
    [Get("/client")]
    Task<IApiResponse<IEnumerable<Client>>> Get();

    [Get("/client/{id}")]
    Task<IApiResponse<Client>> Get(int id);

    [Post("/client")]
    Task<IApiResponse<Client>> Create([Body] Client entity);

    [Put("/client/{id}")]
    Task<IApiResponse> Update(int id, [Body] Client entity);

    [Delete("/client/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IClubOffersApiService
{
    [Get("/cluboffers")]
    Task<IApiResponse<IEnumerable<ClubOffer>>> Get();

    [Get("/cluboffers/{id}")]
    Task<IApiResponse<ClubOffer>> Get(int id);

    [Post("/cluboffers")]
    Task<IApiResponse<ClubOffer>> Create([Body] ClubOffer entity);

    [Put("/cluboffers/{id}")]
    Task<IApiResponse> Update(int id, [Body] ClubOffer entity);

    [Delete("/cluboffers/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface ISupplyOrdersApiService
{
    [Get("/supplyorders")]
    Task<IApiResponse<IEnumerable<SupplyOrder>>> Get();

    [Get("/supplyorders/{id}")]
    Task<IApiResponse<SupplyOrder>> Get(int id);

    [Post("/supplyorders")]
    Task<IApiResponse<SupplyOrder>> Create([Body] SupplyOrder entity);

    [Put("/supplyorders/{id}")]
    Task<IApiResponse> Update(int id, [Body] SupplyOrder entity);

    [Delete("/supplyorders/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IOrdersApiService
{
    [Get("/orders")]
    Task<IApiResponse<IEnumerable<Order>>> Get();

    [Get("/orders/{id}")]
    Task<IApiResponse<Order>> Get(int id);

    [Post("/orders")]
    Task<IApiResponse<Order>> Create([Body] Order entity);

    [Put("/orders/{id}")]
    Task<IApiResponse> Update(int id, [Body] Order entity);

    [Delete("/orders/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IMatchApiService
{
    [Get("/match")]
    Task<IApiResponse<IEnumerable<Match>>> Get();

    [Get("/match/{id}")]
    Task<IApiResponse<Match>> Get(int id);

    [Post("/match")]
    Task<IApiResponse<Match>> Create([Body] Match entity);

    [Put("/match/{id}")]
    Task<IApiResponse> Update(int id, [Body] Match entity);

    [Delete("/match/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface ISuppliedEquipmentApiService
{
    [Get("/suppliedequipment")]
    Task<IApiResponse<IEnumerable<SuppliedEquipment>>> Get();

    [Get("/suppliedequipment/{id}")]
    Task<IApiResponse<SuppliedEquipment>> Get(int id);

    [Post("/suppliedequipment")]
    Task<IApiResponse<SuppliedEquipment>> Create([Body] SuppliedEquipment entity);

    [Put("/suppliedequipment/{id}")]
    Task<IApiResponse> Update(int id, [Body] SuppliedEquipment entity);

    [Delete("/suppliedequipment/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IAvailableEquipmentApiService
{
    [Get("/availableequipment")]
    Task<IApiResponse<IEnumerable<AvailableEquipment>>> Get();

    [Get("/availableequipment/{id}")]
    Task<IApiResponse<AvailableEquipment>> Get(int id);

    [Post("/availableequipment")]
    Task<IApiResponse<AvailableEquipment>> Create([Body] AvailableEquipment entity);

    [Put("/availableequipment/{id}")]
    Task<IApiResponse> Update(int id, [Body] AvailableEquipment entity);

    [Delete("/availableequipment/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IOrderDetailsApiService
{
    [Get("/orderdetails")]
    Task<IApiResponse<IEnumerable<OrderDetail>>> Get();

    [Get("/orderdetails/{id}")]
    Task<IApiResponse<OrderDetail>> Get(int id);

    [Post("/orderdetails")]
    Task<IApiResponse<OrderDetail>> Create([Body] OrderDetail entity);

    [Put("/orderdetails/{id}")]
    Task<IApiResponse> Update(int id, [Body] OrderDetail entity);

    [Delete("/orderdetails/{id}")]
    Task<IApiResponse> Delete(int id);
}

public interface IProductPlacementApiService
{
    [Get("/productplacement")]
    Task<IApiResponse<IEnumerable<ProductPlacement>>> Get();

    [Get("/productplacement/{id}")]
    Task<IApiResponse<ProductPlacement>> Get(int id);

    [Post("/productplacement")]
    Task<IApiResponse<ProductPlacement>> Create([Body] ProductPlacement entity);

    [Put("/productplacement/{id}")]
    Task<IApiResponse> Update(int id, [Body] ProductPlacement entity);

    [Delete("/productplacement/{id}")]
    Task<IApiResponse> Delete(int id);
}