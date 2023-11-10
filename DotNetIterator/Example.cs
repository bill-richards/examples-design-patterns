using System.Text;

namespace gsdc.examples.design_patterns.dotnet_iterator;

public sealed class Example
{
    record Movie(string Title, IEnumerable<string> Stars, uint Year);
    
    static Movie whiteNoise = new Movie("White Noise", Enumerable.Empty<string>(), 2023);
    static Movie dumbWaiter = new Movie("The Dumb Waiter", new[] { "Geraldine Jones" }, 1979);
    static Movie eraserHead = new Movie("Eraser Head", new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" }, 1977);
    static Movie piTheMovie = new Movie("Pi", new[] { "Sean Gullette", "Mark Margolis", "Ben Shenkman" }, 1998);


static string FormatMovie(Movie movie)
    {
        var formatted = new StringBuilder($"\t{movie.Title,-16}").Append('(').Append(movie.Year).Append(')');

        IEnumerator<string> star = movie.Stars.GetEnumerator();
        if (!star.MoveNext()) return formatted.ToString();

        formatted.Append(" starring ").Append(star.Current);
        if (!star.MoveNext()) return formatted.ToString();

        var currentStar = star.Current;
        while (star.MoveNext())
        {
            formatted.Append(", ").Append(currentStar);
            currentStar = star.Current;
        }

        return formatted.Append(", and ").Append(currentStar).ToString();
    }

    public static void Run()
    {
        Console.WriteLine(".net Iterator");
        Console.WriteLine(FormatMovie(whiteNoise));
        Console.WriteLine(FormatMovie(dumbWaiter));
        Console.WriteLine(FormatMovie(eraserHead));
        Console.WriteLine(FormatMovie(piTheMovie));
    }

    public static void Benchmark()
    {
        _ = FormatMovie(whiteNoise);
        _ = FormatMovie(dumbWaiter);
        _ = FormatMovie(eraserHead);
        _ = FormatMovie(piTheMovie);
    }

}
