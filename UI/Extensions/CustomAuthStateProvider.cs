using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Claims;
using System.Text.Json;

namespace UI.Extensions;

public class CustomAuthStateProvider
    : AuthenticationStateProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private const string AuthTokenKey = "AuthToken";

    public CustomAuthStateProvider(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Task<string> GetAuthTokenAsync()
    {
        var token = _httpContextAccessor.HttpContext?.Request.Cookies [AuthTokenKey];
        return Task.FromResult(token);
    }
    public async Task<string?> LoadUserRoleFromToken()
    {
        var authState = await GetAuthenticationStateAsync();
        var user = authState.User;
        if (user.Identity?.IsAuthenticated == true)
        {
            var roleClaim = user.FindFirst(ClaimTypes.Role);
            if (roleClaim != null)
            {
                return roleClaim.Value;
            }
        }
        return null;
    }

    public async Task<int?> LoadUserIdFromToken()
    {
        var authState = await GetAuthenticationStateAsync();
        var user = authState.User;
        if (user.Identity?.IsAuthenticated == true)
        {
            var subClaim = user.FindFirst(ClaimTypes.NameIdentifier) ??
                           user.FindFirst("sub");
            if (subClaim != null && int.TryParse(subClaim.Value, out var userId))
            {
                return userId;
            }
        }

        return null;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var token = _httpContextAccessor.HttpContext?.Request.Cookies [AuthTokenKey];
        var identity = string.IsNullOrEmpty(token)
            ? new ClaimsIdentity()
            : new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");

        var user = new ClaimsPrincipal(identity);
        return Task.FromResult(new AuthenticationState(user));
    }

    private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
    {
        var payload = jwt.Split('.') [1];
        var jsonBytes = WebEncoders.Base64UrlDecode(payload);
        var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
        return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
    }

    public void NotifyAuthenticationStateChanged()
    {
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}