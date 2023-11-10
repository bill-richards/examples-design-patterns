using BenchmarkDotNet.Running;

public class Runner
{
    public static void Run()
    {
        gsdc.examples.design_patterns.iterator_implementation.Example.Run();
        gsdc.examples.design_patterns.dotnet_iterator.Example.Run();
        gsdc.examples.design_patterns.pattern_matching.Example.Run();
        gsdc.examples.design_patterns.sorting.Example.Run();
        Console.ReadKey();
    }

    public static void Benchmark()
    {
        BenchmarkRunner.Run<Benchmarks>();
        Console.ReadKey();
    }
}
