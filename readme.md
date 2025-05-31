[![Build status](https://img.shields.io/appveyor/ci/alunacjones/lsl-servicecollections.svg)](https://ci.appveyor.com/project/alunacjones/lsl-servicecollections)
[![Coveralls branch](https://img.shields.io/coverallsCoverage/github/alunacjones/LSL.ServiceCollections)](https://coveralls.io/github/alunacjones/LSL.ServiceCollections)
[![NuGet](https://img.shields.io/nuget/v/LSL.ServiceCollections.svg)](https://www.nuget.org/packages/LSL.ServiceCollections/)

# LSL.ServiceCollections

A library providing various extensions to `IServiceCollection`

At present it contains:

* Fluently `TryAdd` for all lifetimes (all methods return the original `IServiceCollection` for further chaining)

<!-- HIDE -->
## Further Documentation

More in-depth documentation can be found [here](https://alunacjones.github.io/LSL.ServiceCollections/)

## Fluently adding example

```csharp
var services = new ServiceCollection()
    .FluentlyTryAdd(s => s
        .Singleton<TestClass>()
                    
        // This will not be done as we have already added it
        .Singleton<TestClass>()
        .Singleton<ITestClass, TestClass>()
                    
        // This will not be done as we have already added it
        .Singleton<ITestClass, TestClass>()
        .Transient<TestClass2>()
                    
        // This will not be done as we have already added it (as a transient)
        .Scoped<TestClass2>()
        .Descriptor(ServiceDescriptor.Singleton(typeof(ITestClass), typeof(TestClass)))
    );

// services will only have `TestClass`, `TestClass2` and `ITestClass` registered	}s
```

<!-- END:HIDE -->
