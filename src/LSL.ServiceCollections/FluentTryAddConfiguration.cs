#pragma warning disable IDE0130 // Namespace does not match folder structure
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// FluentTryAddConfiguration
/// </summary>
public sealed class FluentTryAddConfiguration
{
    private readonly IServiceCollection _services;

    internal FluentTryAddConfiguration(IServiceCollection services)
    {
        _services = services;
    }

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns this
    /// for further chaining of calls
    /// </summary>
    public FluentTryAddConfiguration Descriptor(ServiceDescriptor serviceDescriptor)
    {
        _services.TryAdd(serviceDescriptor);
        return this;
    }

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns this
    /// for further chaining of calls
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <returns></returns>    
    public FluentTryAddConfiguration Transient<TService>()
        where TService : class
    {
        _services.FluentlyTryAddTransient<TService>();
        return this;
    }

    /// <summary>
    /// Calls <c>TryAddTransient</c> and returns this
    /// for further chaining of calls
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    /// <returns></returns>
    public FluentTryAddConfiguration Transient<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        _services.FluentlyTryAddTransient<TService, TImplementation>();
        return this;
    }

    /// <summary>
    /// Calls <c>TryAddScoped</c> and returns this
    /// for further chaining of calls
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <returns></returns>
    public FluentTryAddConfiguration Scoped<TService>()
        where TService : class
    {
        _services.FluentlyTryAddScoped<TService>();
        return this;
    }

    /// <summary>
    /// Calls <c>TryAddScoped</c> and returns this
    /// for further chaining of calls
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    /// <returns></returns>
    public FluentTryAddConfiguration Scoped<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        _services.FluentlyTryAddScoped<TService, TImplementation>();
        return this;
    }

    /// <summary>
    /// Calls <c>TryAddSingleton</c> and returns this
    /// for further chaining of calls
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <returns></returns>
    public FluentTryAddConfiguration Singleton<TService>()
        where TService : class
    {
        _services.FluentlyTryAddSingleton<TService>();
        return this;
    }

    /// <summary>
    /// Calls <c>TryAddSingleton</c> and returns this
    /// for further chaining of calls
    /// </summary>
    /// <typeparam name="TService"></typeparam>
    /// <typeparam name="TImplementation"></typeparam>
    /// <returns></returns>
    public FluentTryAddConfiguration Singleton<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        _services.FluentlyTryAddSingleton<TService, TImplementation>();
        return this;
    }
}