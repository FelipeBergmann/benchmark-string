using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringComparisonBenchmark
{
    private static readonly StringComparison _stringComparison = new();
    
    [Benchmark]
    public bool CompareUsingEqualitySignalAndLowerOnce() => _stringComparison.CompareUsingEqualitySignalAndLowerOnce();

    [Benchmark]
    public bool CompareUsingEqualitySignalAndLowerBoth() => _stringComparison.CompareUsingEqualitySignalAndLowerBoth();

    [Benchmark]
    public bool CompareUsingEqualitySignalAndUpperOnce() => _stringComparison.CompareUsingEqualitySignalAndUpperOnce();

    [Benchmark]
    public bool CompareUsingEqualitySignalAndUpperBoth() => _stringComparison.CompareUsingEqualitySignalAndUpperBoth();

    [Benchmark]
    public bool StringCompareMethodOrdinalIgnoreCase() => _stringComparison.StringCompareMethodOrdinalIgnoreCase();

    [Benchmark]
    public bool StringCompareMethodCurrentCultureIgnoreCase() => _stringComparison.StringCompareMethodCurrentCultureIgnoreCase();
    
    [Benchmark]
    public bool StringCompareMethodInvariantCultureIgnoreCase() => _stringComparison.StringCompareMethodInvariantCultureIgnoreCase();
    
    [Benchmark]
    public bool CompareUsingEqualsMethodOrdinalIgnoreCase() => _stringComparison.CompareUsingEqualsMethodOrdinalIgnoreCase();
    
    [Benchmark]
    public bool CompareUsingEqualsMethodCurrentCultureIgnoreCase() => _stringComparison.CompareUsingEqualsMethodCurrentCultureIgnoreCase();
    
    [Benchmark]
    public bool CompareUsingEqualsMethodInvariantCultureIgnoreCase() => _stringComparison.CompareUsingEqualsMethodInvariantCultureIgnoreCase();   
}