using System.Collections.Generic;

namespace lab3
{
    public interface IRepository<T>
    {
        void SortDataByPopulation();
        void SortDataBySquare();
        void AddObject(T obj);
        void DeleteObject(int id);
        List<T> FilterDataByPopulation(int population);
        List<T> FilterDataBySquare(int square);

    }
}