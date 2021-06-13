using System;
using System.Collections.Generic;

namespace QuickSortAlgorithm
{
    //TODO: Move to separate project
    internal static class IListExtension
    {
        public static IList<T> Swap<T>(
            this IList<T> collection,
            int position1,
            int position2)
        {
            if (position1 < 0 || position1 >= collection.Count ||
                position2 < 0 || position2 >= collection.Count)
            {
                throw new IndexOutOfRangeException("Swap index is out of range");
            }

            T tmp = collection[position1];
            collection[position1] = collection[position2];
            collection[position2] = tmp;

            return collection;
        }

        public static IList<T> AddRange<T>(
            this IList<T> collection,
            IList<T> collectionToAdd)
        {
            if (collection == null || collectionToAdd == null)
            {
                throw new NullReferenceException("Collection is null");
            }

            foreach (var item in collectionToAdd)
            {
                collection.Add(item);
            }

            return collection;
        }
    }
}