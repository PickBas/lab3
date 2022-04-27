using System.Collections.Generic;

namespace lab3
{
    public interface IRepository<T>
    {
        void SortData();
        void AddObject();
        void DeleteObject();
        List<T> FilterData();

    }
}