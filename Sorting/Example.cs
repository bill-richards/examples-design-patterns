namespace gsdc.examples.design_patterns.sorting;

public class Example
{
    record Movie(string Title, string[] Stars, uint Year);
        
    static IEnumerable<Movie> movies = new[] 
    {
        new Movie("White Noise", Array.Empty<string>(), 2023),
        new Movie("The Dumb Waiter", new[] { "Geraldine Jones" }, 1979),
        new Movie("Eraser Head", new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" }, 1977),
        new Movie("Pi", new[] { "Sean Gullette", "Mark Margolis", "Ben Shenkman" }, 1998),
        new Movie("The Dumb Waiter", new[] { "Boris Komnenic", "Dragon Petrovic-Pele" }, 1999),
        new Movie("The Dumb Waiter", new[] { "Geraldine Jones", "John White" }, 1979),
        new Movie("The Dumb Waiter", new[] { "Bobby Dunn", "Eddie Lyons" }, 1924),
    };

    static string FormatMovie(Movie movie) => movie.Stars switch                                
    {
        [] => $"\t{movie.Title,-16}({movie.Year})",
        [string star] => $"\t{movie.Title,-16}({movie.Year}) starring {star}",
        [.. string[] stars, string final]
            => $"\t{movie.Title,-16}({movie.Year}) starring {string.Join(", ", stars)} and {final}"
    };

    public static void Run()
    {
        var sortedMovies = movies.OrderBy(movie => movie.Title)             // Chain of responsibility
            .ThenByDescending(movie => movie.Year)                          // Decorator
            .ThenBy(movie => movie.Stars,
                    ComparisonExtensions.AlphabeticComparer<string>());     // Adapter

        Console.WriteLine("Sorting");
        foreach (var m in sortedMovies) Console.WriteLine(FormatMovie(m));   // Iterator
        Console.WriteLine();
    }
    public static void Benchmark()
    {
        var sortedMovies = movies.OrderBy(movie => movie.Title).ThenByDescending(movie => movie.Year)
                                 .ThenBy(movie => movie.Stars, ComparisonExtensions.AlphabeticComparer<string>());     

        foreach (var m in sortedMovies) _ = FormatMovie(m);   
    }
}
