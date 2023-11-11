using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using gsdc.examples.design_patterns.benchmarks;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest), RankColumn]
public class Benchmark
{
    [Benchmark]
    public void Implementation() 
        => ImplementationBenchmark.RunBenchmark();

    [Benchmark]
    public void DotNet() 
        => DotNetBenchmark.RunBenchmark();

    [Benchmark]
    public void PatternMatching() 
        => PatternMatchingBenchmark.RunBenchmark();

    [Benchmark]
    public void Sorting() 
        => SortingBenchmark.RunBenchmark();
}