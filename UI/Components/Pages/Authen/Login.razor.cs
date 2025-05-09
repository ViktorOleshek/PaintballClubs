using Domain.DTOs.Auth;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Services.ExternalApi.Facade;
using System.Net;

namespace UI.Components.Pages.Authen;

public partial class Login : ComponentBase
{
    private LoginModel loginModel = new LoginModel();
    private string? errorMessage;
    private bool isSubmitting = false;
    private bool rememberMe = false;
    private MudForm? loginForm;

    [Parameter]
    [SupplyParameterFromQuery]
    public string? ReturnUrl { get; set; }

    [Inject] private IApiFacade ApiFacade { get; set; } = default!;

    [Inject] private NavigationManager NavigationManager { get; set; } = default!;
    [Inject] private ISnackbar Snackbar { get; set; } = default!;

    [Inject] private IConfiguration Configuration { get; set; } = default!;

    private async Task<bool> ValidateFormAsync()
    {
        if (loginForm is not null)
        {
            await loginForm.Validate();
            return loginForm.IsValid;
        }
        return false;
    }

    private async Task HandleLogin()
    {
        errorMessage = null;
        if (!await ValidateFormAsync())
        {
            return;
        }

        isSubmitting = true;

        var response = await ApiFacade.AuthApiService.Auth(loginModel);

        isSubmitting = false;
        if (response.IsSuccessStatusCode && response.Content != null)
        {
            string encodedReturnUrl = string.IsNullOrEmpty(ReturnUrl)
                ? "/"
                : WebUtility.UrlEncode(ReturnUrl);
            NavigationManager.NavigateTo($"/set-token?AuthToken={response.Content.token}&returnUrl={encodedReturnUrl}", true);
            return;
        }

        errorMessage = response.Error?.Content ?? response.Error?.Message ?? "Сталася невідома помилка";
        Snackbar.Add(errorMessage, Severity.Error);
    }

    private void HandleExternalLogin(string provider)
    {
        string encodedReturnUrl = string.IsNullOrEmpty(ReturnUrl)
            ? "/"
            : WebUtility.UrlEncode(ReturnUrl);

        var apiBaseAddress = Configuration ["CursWorkApi:BaseAddress"];
        var loginUrl = $"{apiBaseAddress}/Identity/{provider}-login?returnUrl={encodedReturnUrl}";

        NavigationManager.NavigateTo(loginUrl, true);
    }
}