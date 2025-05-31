using System;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace LSL.ServiceCollections.Tests;

public class FluentTryAddServiceCollectionExtensionsTests
{
    [Test]
    public void TryToAddTransients()
    {
        var services = new ServiceCollection()
            .FluentlyTryAddTransient<TestClass>()
            .FluentlyTryAddTransient<TestClass>()
            .FluentlyTryAddTransient<ITestClass, TestClass>()
            .FluentlyTryAddTransient<ITestClass, TestClass>();

        using var assertionScope = new AssertionScope();

        services.Should().BeEquivalentTo(
        [
            ServiceDescriptor.Transient(typeof(TestClass), typeof(TestClass)),
            ServiceDescriptor.Transient(typeof(ITestClass), typeof(TestClass))
        ]);
    }

    [Test]
    public void TryToAddScoped()
    {
        var services = new ServiceCollection()
            .FluentlyTryAddScoped<TestClass>()
            .FluentlyTryAddScoped<TestClass>()
            .FluentlyTryAddScoped<ITestClass, TestClass>()
            .FluentlyTryAddScoped<ITestClass, TestClass>();

        using var assertionScope = new AssertionScope();

        services.Should().BeEquivalentTo(
        [
            ServiceDescriptor.Scoped(typeof(TestClass), typeof(TestClass)),
            ServiceDescriptor.Scoped(typeof(ITestClass), typeof(TestClass))
        ]);
    }

    [Test]
    public void TryToAddSingleton()
    {
        var services = new ServiceCollection()
            .FluentlyTryAddSingleton<TestClass>()
            .FluentlyTryAddSingleton<TestClass>()
            .FluentlyTryAddSingleton<ITestClass, TestClass>()
            .FluentlyTryAddSingleton<ITestClass, TestClass>()
            .FluentlyTryAdd(ServiceDescriptor.Singleton<ITestClass, TestClass>());

        using var assertionScope = new AssertionScope();

        services.Should().BeEquivalentTo(
        [
            ServiceDescriptor.Singleton(typeof(TestClass), typeof(TestClass)),
            ServiceDescriptor.Singleton(typeof(ITestClass), typeof(TestClass))
        ]);
    }

    [Test]
    public void GivenANullCollection_ItShouldThrowAnException()
    {
        new Action(() => ((IServiceCollection)null!).FluentlyTryAddTransient<TestClass>())
            .Should()
            .ThrowExactly<ArgumentNullException>()
            .And
            .ParamName.Should().Be("source");
    }
}

public class TestClass : ITestClass
{

}

public interface ITestClass
{

}