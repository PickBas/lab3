using System.Collections.Generic;

namespace lab3.FileWork.Services
{
    public interface IParser<T>
    {
        List<T> ParseDataToObject(List<T> inputData);
    }
}