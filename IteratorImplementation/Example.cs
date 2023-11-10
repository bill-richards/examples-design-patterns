using System.Text;
namespace gsdc.examples.design_patterns.iterator_implementation;

public sealed class Example
{
    record Movie(string Title, IIterator<string> Stars, uint Year);

    static Movie whiteNoise = new Movie("White Noise", new Iterator<string>(Array.Empty<string>()), 2023);
    static Movie dumbWaiter = new Movie("The Dumb Waiter", new Iterator<string>(new[] { "Geraldine Jones" }), 1979);
    static Movie eraserHead = new Movie("Eraser Head", new Iterator<string>(new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" }), 1977);
    static Movie piTheMovie = new Movie("Pi", new Iterator<string>(new[] { "Sean Gullette", "Mark Margolis", "Ben Shenkman" }), 1998);


    static string FormatMovie(Movie movie)
    {
        var formatted = new StringBuilder($"\t{movie.Title,-16}").Append('(').Append(movie.Year).Append(')');

        IIterator<string> stars = movie.Stars;
        if (!stars.MoveNext()) return formatted.ToString();

        formatted.Append(" starring ").Append(stars.Current);
        if (!stars.MoveNext()) return formatted.ToString();

        var star = stars.Current;
        while (stars.MoveNext())
        {
            formatted.Append(", ").Append(star);
            star = stars.Current;
        }

        return formatted.Append(", and ").Append(star).ToString();
    }

    public static void Run()
    {

        Console.WriteLine("Implemented Iterator");
        Console.WriteLine(FormatMovie(whiteNoise));
        Console.WriteLine(FormatMovie(dumbWaiter));
        Console.WriteLine(FormatMovie(eraserHead));
        Console.WriteLine(FormatMovie(piTheMovie));
        Console.WriteLine();
    }

    public static void Benchmark()
    {
        _ = FormatMovie(whiteNoise);
        _ = FormatMovie(dumbWaiter);
        _ = FormatMovie(eraserHead);
        _ = FormatMovie(piTheMovie);
    }

}
