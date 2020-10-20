# 24NettbutikkSharp: A .NET library for 24NettbutikkSharp.

24NettbutikkSharp is a .NET library that enables you to authenticate and make API calls to 24NettbutikkSharp. It's great for 
building custom 24NettbutikkSharp Apps using C# and .NET. You can quickly and easily get up and running with 24NettbutikkSharp
using this library.

# Installation

24NettbutikkSharp is [available on NuGet](https://www.nuget.org/packages/24NettbutikkSharp/). Use the package manager
console in Visual Studio to install it:

```
Install-Package 24NettbutikkSharp
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```
dotnet add package 24NettbutikkSharp
```

# Using 24NettbutikkSharp

**Note**: All instances of `apiKey` in the examples below **do not refer to your 24NettbutikkSharp API key**.


```cs
var service = new ProductService(string storeUrl, string apiKey);
```

# APIS Implemented
- Order
- Product
