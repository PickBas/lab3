using System.Collections.Generic;

namespace lab3.FileWork.Services
{
    public interface IReader <T>
    {
        List<T> GetData(string filePath);

    }
}