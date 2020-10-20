# NettbutikkSharp: A .NET library for NettbutikkSharp.

NettbutikkSharp is a .NET library that enables you to authenticate and make API calls to Nettbutikk. It's great for 
building custom Nettbutikk Apps using C# and .NET. You can quickly and easily get up and running with Nettbutikk
using this library.

# Installation

NettbutikkSharp is [available on NuGet](https://www.nuget.org/packages/NettbutikkSharp/). Use the package manager
console in Visual Studio to install it:

```
Install-Package NettbutikkSharp
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```
dotnet add package NettbutikkSharp
```

# Using NettbutikkSharp

**Note**: All instances of `apiKey` in the examples below **do not refer to your NettbutikkSharp API key**.


```cs
var service = new ProductService(string storeUrl, string apiKey);
```

# APIS Implemented
- Order
- Product
