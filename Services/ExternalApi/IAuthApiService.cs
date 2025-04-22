using Domain.DTOs.Auth;
using Refit;

namespace Services.ExternalApi;

public interface IAuthApiService
{
    [Post("/auth")]
    Task<IApiResponse<LoginResponse>> Auth([Body] LoginModel request);
}