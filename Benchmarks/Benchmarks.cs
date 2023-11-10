using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest), RankColumn]
public class Benchmarks
{
    [Benchmark]
    public void Implementation()
    {
        gsdc.examples.design_patterns.iterator_implementation.Example.Benchmark();
    }

    [Benchmark]
    public void DotNet()
    {
        gsdc.examples.design_patterns.dotnet_iterator.Example.Benchmark();
    }

    [Benchmark]
    public void PatternMatching()
    {
        gsdc.examples.design_patterns.pattern_matching.Example.Benchmark();
    }

    [Benchmark]
    public void Sorting()
    {
        gsdc.examples.design_patterns.sorting.Example.Benchmark();
    }
}