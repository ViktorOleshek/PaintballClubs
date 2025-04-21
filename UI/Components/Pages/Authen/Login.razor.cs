//using Domain.Models.Account.Login;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using MudBlazor;
//using Services.Abstraction;
//using Services.ExternalApi;
//using System.Net;
//namespace UI.Components.Pages.Authen;
//public partial class Login : ComponentBase
//{
//    private LoginModel loginModel = new LoginModel();
//    private LoginModelValidation loginModelValidation = new LoginModelValidation();
//    private string? errorMessage;
//    private bool isSubmitting = false;
//    private bool rememberMe = false;
//    private MudForm? loginForm;

//    [Parameter]
//    [SupplyParameterFromQuery]
//    public string? ReturnUrl { get; set; }

//    [Inject]
//    private IApiFacade ApiFacade { get; set; } = default!;

//    [Inject]
//    private NavigationManager NavigationManager { get; set; } = default!;

//    [Inject]
//    private IErrorHandlingService ErrorHandlingService { get; set; } = default!;

//    [Inject] private IConfiguration Configuration { get; set; } = default!;

//    private async Task<bool> ValidateFormAsync()
//    {
//        if (loginForm is not null)
//        {
//            await loginForm.Validate();
//            return loginForm.IsValid;
//        }
//        return false;
//    }

//    private async Task HandleLogin()
//    {
//        errorMessage = null;
//        if (!await ValidateFormAsync())
//        {
//            return;
//        }

//        isSubmitting = true;

//        // Add rememberMe
//        var response = await ApiFacade.Auth.LoginAsync(loginModel);

//        if (response.IsSuccessStatusCode && response.Content != null)
//        {
//            string encodedReturnUrl = string.IsNullOrEmpty(ReturnUrl)
//                ? "/"
//                : WebUtility.UrlEncode(ReturnUrl);
//            NavigationManager.NavigateTo($"/set-token?AuthToken={response.Content.Token}&returnUrl={encodedReturnUrl}", true);
//            return;
//        }

//        errorMessage = ErrorHandlingService.HandleError(response.Error);
//    }

//    private void HandleExternalLogin(string provider)
//    {
//        string encodedReturnUrl = string.IsNullOrEmpty(ReturnUrl)
//            ? "/"
//            : WebUtility.UrlEncode(ReturnUrl);

//        var apiBaseAddress = Configuration ["TaskTrackerApi:BaseAddress"];
//        var loginUrl = $"{apiBaseAddress}/Identity/{provider}-login?returnUrl={encodedReturnUrl}";

//        NavigationManager.NavigateTo(loginUrl, true);
//    }
//}