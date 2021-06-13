using System;
using System.Collections.Generic;

namespace QuickSortAlgorithm
{
    //TODO: move to another project and link here, possibly will be removed
    public interface ICustomSort
    {
        IList<T> Sort<T>(IList<T> collection) where T : IComparable<T>;
    }
}