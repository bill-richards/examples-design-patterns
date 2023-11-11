using System.Text;
namespace gsdc.examples.design_patterns.iterator_implementation;

public class Example
{
    protected record Movie(string Title, IIterator<string> Stars, uint Year);

    protected static Movie whiteNoise = new("White Noise", new Iterator<string>(Array.Empty<string>()), 2023);
    protected static Movie dumbWaiter = new("The Dumb Waiter", new Iterator<string>(new[] { "Geraldine Jones" }), 1979);
    protected static Movie eraserHead = new("Eraser Head", new Iterator<string>(new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" }), 1977);
    protected static Movie piTheMovie = new("Pi", new Iterator<string>(new[] { "Sean Gullette", "Mark Margolis", "Ben Shenkman" }), 1998);
    protected static Movie dumbWaiter1 = new("The Dumb Waiter", new Iterator<string>(new[] { "Geraldine Jones", "John White" }), 1979);
    protected static Movie dumbWaiter2 = new("The Dumb Waiter", new Iterator<string>(new[] { "Bobby Dunn", "Eddie Lyons" }), 1924);
    protected static Movie dumbWaiter3 = new("The Dumb Waiter", new Iterator<string>(new[] { "Boris Komnenic", "Dragon Petrovic-Pele" }), 1999);


    protected static string FormatMovie(Movie movie)
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

        return formatted.Append(" and ").Append(star).ToString();
    }

    public static void Run()
    {

        Console.WriteLine("Implemented Iterator");
        Console.WriteLine(FormatMovie(whiteNoise));
        Console.WriteLine(FormatMovie(dumbWaiter));
        Console.WriteLine(FormatMovie(eraserHead));
        Console.WriteLine(FormatMovie(piTheMovie));
        Console.WriteLine(FormatMovie(dumbWaiter1));
        Console.WriteLine(FormatMovie(dumbWaiter2));
        Console.WriteLine(FormatMovie(dumbWaiter3));
    }
}
