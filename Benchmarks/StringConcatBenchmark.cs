using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringConcatBenchmark
{
    private static readonly StringConcat _stringConcat = new();
    
    [Benchmark]
    public void ConcatUsingFormat() 
    {
        var result = _stringConcat.ConcatUsingFormat();
    }

    [Benchmark]
    public void ConcatUsingPlusSignalConcat() 
    {
        var result = _stringConcat.ConcatUsingPlusSignalConcat();
    }

    [Benchmark]
    public void ConcatUsingStringInterpolation() 
    {
        var result = _stringConcat.ConcatUsingStringInterpolation();
    }

    [Benchmark]
    public void ConcatUsingStringBuilder() 
    {
        var result = _stringConcat.ConcatUsingStringBuilder();
    }
}