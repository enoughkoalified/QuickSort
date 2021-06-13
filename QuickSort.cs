using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSortAlgorithm
{
    internal class QuickSort : ICustomSort
    {
        public IList<T> Sort<T>(IList<T> collection) where T : IComparable<T>
        {
            if (collection == null)
                throw new NullReferenceException("Quick Sort Collection is null");

            if (collection.Count() == 0)
                return collection;

            if (collection.Count == 1)
            {
                return collection;
            }

            if (collection.Count == 2)
            {
                if (collection[1].CompareTo(collection[0]) < 0)
                {
                    collection.Swap(0, 1);
                }
                return collection;
            }

            var pivotElement = collection[collection.Count / 2];

            var leftPart = collection
                            .Where(x => x.CompareTo(pivotElement) < 0)
                            .ToList();
            var rightPart = collection
                            .Where(x => x.CompareTo(pivotElement) > 0)
                            .ToList();
            var middlePart = collection
                            .Where(x => x.CompareTo(pivotElement) == 0)
                            .ToList();

            var sortedLeftPart = Sort(leftPart);
            var sortedRightPart = Sort(rightPart);

            return sortedLeftPart
                    .AddRange(middlePart)
                    .AddRange(sortedRightPart);
        }
    }
}