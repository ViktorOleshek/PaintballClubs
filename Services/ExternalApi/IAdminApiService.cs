using Domain.Entities;
using Refit;

namespace Services.ExternalApi;

public interface IAdminApiService
{
    [Get("/admin")]
    Task<IApiResponse<IEnumerable<User>>> Get();

    [Get("/admin/{id}")]
    Task<IApiResponse<User>> Get(int id);

    [Post("/admin")]
    Task<IApiResponse<User>> Create([Body] User entity);

    [Put("/admin/{id}")]
    Task<IApiResponse> Update(int id, [Body] User entity);

    [Delete("/admin/{id}")]
    Task<IApiResponse> Delete(int id);
}
