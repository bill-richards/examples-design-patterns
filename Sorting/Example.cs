﻿namespace gsdc.examples.design_patterns.sorting;

public class Example
{
    protected record Movie(string Title, string[] Stars, uint Year);

    protected static IEnumerable<Movie> movies = new Movie[] 
    {
        new("White Noise", Array.Empty<string>(), 2023),
        new("The Dumb Waiter", new[] { "Geraldine Jones" }, 1979),
        new("Eraser Head", new[] { "Jack Nance", "Charlotte Stewart", "Allen Joseph" }, 1977),
        new("Pi", new[] { "Sean Gullette", "Mark Margolis", "Ben Shenkman" }, 1998),
        new("The Dumb Waiter", new[] { "Geraldine Jones", "John White" }, 1979),
        new("The Dumb Waiter", new[] { "Bobby Dunn", "Eddie Lyons" }, 1924),
        new("The Dumb Waiter", new[] { "Boris Komnenic", "Dragon Petrovic-Pele" }, 1999),
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
        var sortedMovies = movies.OrderBy(movie => movie.Title)             // Chain of responsibility
            .ThenByDescending(movie => movie.Year)                          // Decorator
            .ThenBy(movie => movie.Stars,
                    ComparisonExtensions.AlphabeticComparer<string>());     // Adapter

        Console.WriteLine("Sorting");
        foreach (var m in sortedMovies) Console.WriteLine(FormatMovie(m));   // Iterator
    }
}
