using System;

namespace LSL.ServiceCollections;

internal static class GuardExtensions
{
    public static T AssertNotNull<T>(
        this T value,
        string parameterName) => value ?? throw new ArgumentNullException(parameterName, "Argument cannot be null");
}