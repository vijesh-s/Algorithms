using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Sorter.Test
{
    
    public class SorterTests
    {
        [Fact]
        public void Test()
        {
            ISorter<int> sorter = new MergeSorter<int>();

            var listOfInts = new List<int> { 34, 65, 234, 345, 56, 2, 65 };

            listOfInts.Sort();
            var sortedList = sorter.SortIt(listOfInts);
            Assert.True(listOfInts.SequenceEqual(sortedList));
        }
    }
}
