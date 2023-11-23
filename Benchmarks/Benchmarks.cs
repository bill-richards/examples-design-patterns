namespace gsdc.examples.design_patterns.benchmarks;

internal class DotNetBenchmark : dotnet_iterator.Example
{
    public static void RunBenchmark()
    {
        _ = FormatMovie(whiteNoise);
        _ = FormatMovie(dumbWaiter);
        _ = FormatMovie(eraserHead);
        _ = FormatMovie(piTheMovie);
    }

    public static void RunSingleMovieBenchmark()
        => _ = FormatMovie(eraserHead);
}

internal class ImplementationBenchmark : iterator_implementation.Example
{
    public static void RunBenchmark()
    {
        _ = FormatMovie(whiteNoise);
        _ = FormatMovie(dumbWaiter);
        _ = FormatMovie(eraserHead);
        _ = FormatMovie(piTheMovie);
    }

    public static void RunSingleMovieBenchmark() 
        => _ = FormatMovie(eraserHead);
}

internal class PatternMatchingBenchmark : pattern_matching.Example
{
    public static void RunBenchmark()
    {
        foreach (var m in movies) _ = FormatMovie(m);
    }

    public static void RunSingleMovieBenchmark()
        => _ = FormatMovie(eraserHead);
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