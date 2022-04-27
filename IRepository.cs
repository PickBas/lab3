using System.Collections.Generic;

namespace lab3
{
    public interface IRepository
    {
        void SortData();
        void AddObject();
        void DeleteObject();
        List<object> FilterData();

    }
}