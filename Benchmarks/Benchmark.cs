using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using gsdc.examples.design_patterns.benchmarks;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest), RankColumn]
public class Benchmark
{
    [Benchmark]
    public void ImplementationBenchmark() 
        => Implementation.RunBenchmark();

    [Benchmark]
    public void DotNetBenchmark() 
        => DotNet.RunBenchmark();

    [Benchmark]
    public void PatternMatchingBenchmark() 
        => PatternMatching.RunBenchmark();

    [Benchmark]
    public void SortingBenchmark() 
        => Sorting.RunBenchmark();
}