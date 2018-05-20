using System;
using System.Collections.Generic;

namespace Sorter
{
    public interface ISorter<T> where T : IComparable
    {
        IList<T> SortIt(IList<T> collection);
    }
}
