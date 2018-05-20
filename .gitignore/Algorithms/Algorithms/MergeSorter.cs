using System;
using System.Collections.Generic;

namespace Sorter
{
    public class MergeSorter<T> : ISorter<T> where T: IComparable 
    {
        private IList<T> _input = new List<T>();
        private IList<T> _tempList = new List<T>();


        public IList<T> SortIt(IList<T> collection)
        {
            foreach (var item in collection)
            {
                _input.Add(item);
            }
            var right = _input.Count - 1;
            var left = 0;

            foreach(var item in _input)
            {
                _tempList.Add(item);
            }

            MergeSort(left, right);

            return _tempList;
        }

        protected void Merge(int left, int mid, int right)
        {
            var sortedListIndex = left;
            var leftListIndex = left;
            var rightListIndex = mid + 1;

            while (leftListIndex <= mid && rightListIndex <= right)
            {
                if (_input[leftListIndex].CompareTo(_input[rightListIndex]) <= 0)
                {
                    _tempList[sortedListIndex++] = _input[leftListIndex++];
                }
                else
                {
                    _tempList[sortedListIndex++] = _input[rightListIndex++];
                }
            }

            while (leftListIndex <= mid)
            {
                _tempList[sortedListIndex++] = _input[leftListIndex++];
            }

            _input.Clear();
            foreach (T item in _tempList)
            {
                _input.Add(item);
            }
        }

        protected void MergeSort(int left, int right)
        {
            if (left < right)
            {
                var mid = (left + right) / 2;
                MergeSort(left, mid);
                MergeSort(mid + 1, right);
                Merge(left, mid, right);
            }
        }
    }
}
