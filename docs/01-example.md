# Fluently adding example

```csharp { data-fiddle="rViSeD" }
var services = new ServiceCollection()
    .FluentlyTryAdd(s => s
        .Singleton<TestClass>()
                    
        // This will not be done as we have already 
        // added it
        .Singleton<TestClass>()

        // This will be added
        .Singleton<ITestClass, TestClass>()
                    
        // This will not be done as we have already 
        // added it
        .Singleton<ITestClass, TestClass>()

        // This will be added
        .Transient<TestClass2>()
                    
        // This will not be done as we have already 
        // added it (as a transient)
        .Scoped<TestClass2>()

        // This will not be done as we have already 
        // added it
        .Descriptor(ServiceDescriptor.Singleton(
            typeof(ITestClass), 
            typeof(TestClass)))
    );

// services will only have:
// `TestClass`, `TestClass2` and `ITestClass` registered
```
