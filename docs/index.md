[![Build status](https://img.shields.io/appveyor/ci/alunacjones/lsl-servicecollections.svg)](https://ci.appveyor.com/project/alunacjones/lsl-servicecollections)
[![Coveralls branch](https://img.shields.io/coverallsCoverage/github/alunacjones/LSL.ServiceCollections)](https://coveralls.io/github/alunacjones/LSL.ServiceCollections)
[![NuGet](https://img.shields.io/nuget/v/LSL.ServiceCollections.svg)](https://www.nuget.org/packages/LSL.ServiceCollections/)

# LSL.ServiceCollections

A library providing various extensions to `IServiceCollection`

At present it contains:

* Fluently `TryAdd` for all lifetimes (all methods return the original `IServiceCollection` for further chaining)
