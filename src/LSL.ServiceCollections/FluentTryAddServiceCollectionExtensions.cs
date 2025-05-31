using System;
using LSL.ServiceCollections;
using Microsoft.Extensions.DependencyInjection.Extensions;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;
#pragma warning restore IDE0130 // Namespace does not match folder structure

/// <summary>
/// FluentTryAddServiceCollectionExtensions
/// </summary>
public static class FluentTryAddServiceCollectionExtensions
{
    /// <summary>
    /// Fluently to try add services via a configurator
    /// </summary>
    /// <param name="source"></param>
    /// <param name="configurator"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAdd(this IServiceCollection source, Action<FluentTryAddConfiguration> configurator)
    {
        var configuration = new FluentTryAddConfiguration(source);
        configurator.AssertNotNull(nameof(configurator))(configuration);

        return source;
    }

    /// <summary>
    /// Calls <c>TryAdd</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="serviceDescriptor"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAdd(this IServiceCollection source, ServiceDescriptor serviceDescriptor)
    {
        source.AssertNotNull(nameof(source)).TryAdd(serviceDescriptor.AssertNotNull(nameof(serviceDescriptor)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddTransient<TService, TImplementation>(this IServiceCollection source)
        where TService : class
        where TImplementation : class, TService =>
        source.FluentlyTryAddTransient(typeof(TService), typeof(TImplementation));

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddTransient<TService>(this IServiceCollection source)
        where TService : class =>
        source.FluentlyTryAddTransient(typeof(TService));

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="service"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddTransient(this IServiceCollection source, Type service)
    {
        source.AssertNotNull(nameof(source)).TryAddTransient(service.AssertNotNull(nameof(service)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="service"></param>
    /// <param name="implementation"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddTransient(this IServiceCollection source, Type service, Type implementation)
    {
        source.AssertNotNull(nameof(source)).TryAddTransient(service.AssertNotNull(nameof(service)), implementation.AssertNotNull(nameof(implementation)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddScoped</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="service"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddScoped(this IServiceCollection source, Type service)
    {
        source.AssertNotNull(nameof(source)).TryAddScoped(service.AssertNotNull(nameof(service)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddScoped</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="service"></param>
    /// <param name="implementation"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddScoped(this IServiceCollection source, Type service, Type implementation)
    {
        source.AssertNotNull(nameof(source)).TryAddScoped(service.AssertNotNull(nameof(service)), implementation.AssertNotNull(nameof(implementation)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddScoped</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddScoped<TService, TImplementation>(this IServiceCollection source)
        where TService : class
        where TImplementation : class, TService =>
        source.FluentlyTryAddScoped(typeof(TService), typeof(TImplementation));

    /// <summary>
    /// Calls <c>TryAddScoped</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddScoped<TService>(this IServiceCollection source)
        where TService : class =>
        source.FluentlyTryAddScoped(typeof(TService));

    /// <summary>
    /// Calls <c>TryAddSingleton</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="service"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddSingleton(this IServiceCollection source, Type service)
    {
        source.AssertNotNull(nameof(source)).TryAddSingleton(service.AssertNotNull(nameof(service)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddSingleton</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <param name="source"></param>
    /// <param name="service"></param>
    /// <param name="implementation"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddSingleton(this IServiceCollection source, Type service, Type implementation)
    {
        source.AssertNotNull(nameof(source)).TryAddSingleton(service.AssertNotNull(nameof(service)), implementation.AssertNotNull(nameof(implementation)));
        return source;
    }

    /// <summary>
    /// Calls <c>TryAddSingleton</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddSingleton<TService, TImplementation>(this IServiceCollection source)
        where TService : class
        where TImplementation : class, TService =>
        source.FluentlyTryAddSingleton(typeof(TService), typeof(TImplementation));

    /// <summary>
    /// Calls <c>TryAddSingleton</c> and returns the original <see cref="IServiceCollection"/>
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IServiceCollection FluentlyTryAddSingleton<TService>(this IServiceCollection source)
        where TService : class =>
        source.FluentlyTryAddSingleton(typeof(TService));
}
