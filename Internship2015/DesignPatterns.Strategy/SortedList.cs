using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class SortedList
    {
        private readonly List<string> _list;

        private ISortStrategy _sortStrategy;

        public SortedList()
        {
            _list = new List<string>();
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
        }

        public override string ToString()
        {
            return string.Join(", ", _list);
        }

    }
}