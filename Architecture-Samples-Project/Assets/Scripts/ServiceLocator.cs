using System;
using System.Collections.Generic;

public static class ServiceLocator
{
    private static readonly Dictionary<(Type, int), object> ServiceMap = new();

    public static void Reset()
    {
        ServiceMap.Clear();
    }

    public static void RegisterService<TInterface, TImplementation>(TImplementation instance, int id = 0)
             where TInterface : class
             where TImplementation : notnull, TInterface
    {
        ServiceMap[(typeof(TInterface), id)] = instance;
    }

    public static TInterface GetService<TInterface>(int id = 0)
        where TInterface : class
    {
        return ServiceMap.TryGetValue((typeof(TInterface), id), out object instance) 
            ? instance as TInterface 
            : null;
    }
}