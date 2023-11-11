namespace gsdc.examples.design_patterns.benchmarks;

internal class DotNetBenchmark : dotnet_iterator.Example
{
    public static void RunBenchmark()
    {
        _ = FormatMovie(whiteNoise);
        _ = FormatMovie(dumbWaiter);
        _ = FormatMovie(eraserHead);
        _ = FormatMovie(piTheMovie);
        _ = FormatMovie(dumbWaiter1);
        _ = FormatMovie(dumbWaiter2);
        _ = FormatMovie(dumbWaiter3);
    }

    public static void RunSingleMovieBenchmark()
        => _ = FormatMovie(dumbWaiter3);
}

internal class ImplementationBenchmark : iterator_implementation.Example
{
    public static void RunBenchmark()
    {
        _ = FormatMovie(whiteNoise);
        _ = FormatMovie(dumbWaiter);
        _ = FormatMovie(eraserHead);
        _ = FormatMovie(piTheMovie);
        _ = FormatMovie(dumbWaiter1);
        _ = FormatMovie(dumbWaiter2);
        _ = FormatMovie(dumbWaiter3);
    }

    public static void RunSingleMovieBenchmark() 
        => _ = FormatMovie(dumbWaiter3);
}

internal class PatternMatchingBenchmark : pattern_matching.Example
{
    public static void RunBenchmark()
    {
        foreach (var m in movies) _ = FormatMovie(m);
    }
}

internal class SortingBenchmark : sorting.Example
{
    public static void RunBenchmark()
    {
        var sortedMovies = movies.OrderBy(movie => movie.Title).ThenByDescending(movie => movie.Year)
                                 .ThenBy(movie => movie.Stars, ComparisonExtensions.AlphabeticComparer<string>());

        foreach (var m in sortedMovies) _ = FormatMovie(m);
    }
}