# Benchmark Working With Strings
Tests using BenchmarkNET library and .net 6 for string concat and comparison

# Description
A simple proof of concept using BenchmarkNET library to test how fast and memory usage running operations to concat and compare strings

# How to test
You should open the terminal at your directory and run the commands:
You must always runs benchmark as release. Dotnet will optimize the code for release.

```
> dotnet build -c Release
> dotnet <YourReleaseDLLPath> //e.g. dotnet c:\\repository\project\bin\release\net6.0\BenchmarkWorkingWithStrings.dll
```

# Results
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```

|                                             Method |       Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|--------------------------------------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|          CompareUsingEqualsMethodOrdinalIgnoreCase |   5.634 ns | 0.1366 ns | 0.1278 ns |    1 |      - |         - |
|               StringCompareMethodOrdinalIgnoreCase |  14.034 ns | 0.1628 ns | 0.1522 ns |    2 |      - |         - |
|             CompareUsingEqualitySignalAndUpperOnce |  21.856 ns | 0.4724 ns | 1.2770 ns |    3 |      - |         - |
|             CompareUsingEqualitySignalAndLowerOnce |  42.631 ns | 1.5090 ns | 4.3779 ns |    4 | 0.0191 |      40 B |
|             CompareUsingEqualitySignalAndUpperBoth |  61.735 ns | 1.7003 ns | 4.7398 ns |    5 | 0.0191 |      40 B |
|             CompareUsingEqualitySignalAndLowerBoth |  72.486 ns | 2.7525 ns | 7.8975 ns |    6 | 0.0191 |      40 B |
|      StringCompareMethodInvariantCultureIgnoreCase | 121.655 ns | 2.4521 ns | 2.2937 ns |    7 |      - |         - |
| CompareUsingEqualsMethodInvariantCultureIgnoreCase | 130.981 ns | 2.6288 ns | 2.4590 ns |    8 |      - |         - |
|   CompareUsingEqualsMethodCurrentCultureIgnoreCase | 137.357 ns | 2.7963 ns | 4.6721 ns |    9 |      - |         - |
|        StringCompareMethodCurrentCultureIgnoreCase | 137.411 ns | 2.6964 ns | 2.3903 ns |    9 |      - |         - |


|                         Method |      Mean |    Error |   StdDev |    Median | Rank |  Gen 0 | Allocated |
|------------------------------- |----------:|---------:|---------:|----------:|-----:|-------:|----------:|
|    ConcatUsingPlusSignalConcat |  60.54 ns | 1.763 ns | 5.002 ns |  60.44 ns |    1 | 0.0726 |     152 B |
| ConcatUsingStringInterpolation |  64.95 ns | 1.436 ns | 3.680 ns |  66.88 ns |    2 | 0.0421 |      88 B |
|              ConcatUsingFormat |  98.77 ns | 2.044 ns | 3.471 ns | 100.17 ns |    3 | 0.0381 |      80 B |
|       ConcatUsingStringBuilder | 106.08 ns | 2.657 ns | 7.834 ns | 109.36 ns |    4 | 0.1376 |     288 B |
