using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}