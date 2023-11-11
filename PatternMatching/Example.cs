namespace gsdc.examples.design_patterns.pattern_matching;

public class Example
{
    protected record Movie(string Title, string[] Stars, uint Year);

    protected static IEnumerable<Movie> movies = new Movie[]
    {
        new("White Noise", Array.Empty<string>(), 2023),
        new("The Dumb Waiter", new[] { "Geraldine Jones" }, 1979),
        new("Eraser Head", new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" }, 1977),
        new("Pi", new[] { "Sean Gullette", "Mark Margolis", "Ben Shenkman" }, 1998),
    };

    protected static string FormatMovie(Movie movie) => movie.Stars switch
    {
        [] => $"\t{movie.Title,-16}({movie.Year})",
        [string star] => $"\t{movie.Title,-16}({movie.Year}) starring {star}",
        [.. string[] stars, string final]
            => $"\t{movie.Title,-16}({movie.Year}) starring {string.Join(", ", stars)} and {final}"
    };

    public static void Run()
    {
        Console.WriteLine("Pattern Matching");
        foreach (var m in movies) Console.WriteLine(FormatMovie(m));
    }

}
