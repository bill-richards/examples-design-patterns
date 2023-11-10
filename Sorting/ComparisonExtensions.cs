namespace gsdc.examples.design_patterns.sorting;

public static class ComparisonExtensions
{
    public static int CompareAlphabetically<T>(this T[] lhs, T[] rhs) where T : IComparable<T>
    {
        var length = Math.Min(lhs.Length, rhs.Length);

        for (int index = 0; index < length; index++)
        {
            var comparison = lhs[index].CompareTo(rhs[index]);
            if (comparison != 0) return comparison;
        }

        return lhs.Length.CompareTo(rhs.Length);
    }

    public static IComparer<T[]> AlphabeticComparer<T>() where T : IComparable<T> 
        => Comparer<T[]>.Create((lhs, rhs) => lhs.CompareAlphabetically(rhs));
}
