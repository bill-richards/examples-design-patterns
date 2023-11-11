using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using gsdc.examples.design_patterns.benchmarks;

[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest), RankColumn]
public class Benchmark
{
    [Benchmark] public void Implementation_SingleMovie()
        => ImplementationBenchmark.RunSingleMovieBenchmark();

    [Benchmark]
    public void DotNet_SingleMovie()
        => DotNetBenchmark.RunSingleMovieBenchmark();

    [Benchmark] public void PatternMatching_SingleMovie()
        => PatternMatchingBenchmark.RunSingleMovieBenchmark();

    [Benchmark] public void Implementation()
        => ImplementationBenchmark.RunBenchmark();

    [Benchmark] public void DotNet() 
        => DotNetBenchmark.RunBenchmark();

    [Benchmark] public void PatternMatching() 
        => PatternMatchingBenchmark.RunBenchmark();

    [Benchmark] public void Sorting() 
        => SortingBenchmark.RunBenchmark();
}