using System;
using System.Collections.Generic;
namespace QuickSortAlgorithm
{
    internal static class QuickSortExtension
    {
        public static IEnumerable<T> QuickSort<T>(this IList<T> input) where T : IComparable<T>
        {
            return new QuickSort().Sort<T>(input);
        }
    }
}