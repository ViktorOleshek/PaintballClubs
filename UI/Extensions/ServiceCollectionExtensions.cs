﻿using BlazorDownloadFile;
using Domain.Constants;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using Services.ExternalApi;
using Services.ExternalApi.Facade;
using System.Net.Http.Headers;

namespace UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApi(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddBlazorDownloadFile(ServiceLifetime.Scoped);
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        services.AddScoped<TokenHttpMessageHandler>();

        var settings = configuration
                        .GetSection(CursWorkSettings.ConfigurationSection)
                        .Get<CursWorkSettings>();
        services.AddHttpClient("CursWorkApi", client =>
        {
            client.BaseAddress = new Uri(settings!.BaseAddress);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json-patch+json"));
        })
                .AddHttpMessageHandler<TokenHttpMessageHandler>();

        var refitSettings = new RefitSettings
        {
            ContentSerializer = new NewtonsoftJsonContentSerializer(
                    new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver(),
                        NullValueHandling = NullValueHandling.Ignore
                    })
        };
        services.AddRefitService<IAuthApiService>(refitSettings);
        services.AddRefitService<IAdminApiService>(refitSettings);

        services.AddRefitService<ISuppliersApiService>(refitSettings);
        services.AddRefitService<ISupplyOrderStatusApiService>(refitSettings);
        services.AddRefitService<ILocationApiService>(refitSettings);
        services.AddRefitService<IPositionApiService>(refitSettings);
        services.AddRefitService<IClubApiService>(refitSettings);
        services.AddRefitService<IEmployeeApiService>(refitSettings);
        services.AddRefitService<ICategoryApiService>(refitSettings);
        services.AddRefitService<IBrandApiService>(refitSettings);
        services.AddRefitService<ITypeApiService>(refitSettings);
        services.AddRefitService<IEquipmentApiService>(refitSettings);
        services.AddRefitService<IOrderStatusApiService>(refitSettings);
        services.AddRefitService<IClientApiService>(refitSettings);
        services.AddRefitService<IClubOffersApiService>(refitSettings);
        services.AddRefitService<ISupplyOrdersApiService>(refitSettings);
        services.AddRefitService<IOrdersApiService>(refitSettings);
        services.AddRefitService<IMatchApiService>(refitSettings);
        services.AddRefitService<ISuppliedEquipmentApiService>(refitSettings);
        services.AddRefitService<IAvailableEquipmentApiService>(refitSettings);
        services.AddRefitService<IOrderDetailsApiService>(refitSettings);
        services.AddRefitService<IProductPlacementApiService>(refitSettings);

        services.AddScoped<IApiFacade, ApiFacade>();

        AddPolicy(services);

        return services;
    }
    private static IServiceCollection AddRefitService<T>(
        this IServiceCollection services,
        RefitSettings settings)
        where T : class
    {
        services.AddScoped<T>(sp =>
        {
            var httpClient = sp.GetRequiredService<IHttpClientFactory>()
                .CreateClient("CursWorkApi");
            return RestService.For<T>(httpClient, settings);
        });

        return services;
    }

    private static IServiceCollection AddPolicy(
    this IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            // Базові політики для ролей
            options.AddPolicy(Roles.GlobalAdmin, policy => policy.RequireRole(Roles.GlobalAdmin));
            options.AddPolicy(Roles.OfficeManager, policy => policy.RequireRole(Roles.OfficeManager));
            options.AddPolicy(Roles.TechnicalSpecialist, policy => policy.RequireRole(Roles.TechnicalSpecialist));
            options.AddPolicy(Roles.WarehouseWorker, policy => policy.RequireRole(Roles.WarehouseWorker));

            // Комбіновані політики
            options.AddPolicy(Policies.OfficeManagerAndWarehouseWorker, policy =>
                policy.RequireRole(Roles.OfficeManager, Roles.WarehouseWorker));

            //// Політика з власною логікою
            //options.AddPolicy("CanManageEmployees", policy =>
            //    policy.RequireAssertion(context =>
            //        context.User.IsInRole("Admin") ||
            //        context.User.IsInRole("HR") ||
            //        (context.User.IsInRole("Manager") && context.User.HasClaim(c =>
            //            c.Type == "Department" && c.Value == "HR"))
            //    ));
        });

        return services;
    }
}