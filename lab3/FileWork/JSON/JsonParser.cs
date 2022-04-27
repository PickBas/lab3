using System.Collections.Generic;
using lab3.FileWork.Services;

namespace lab3.FileWork.JSON
{
    public class JsonParser<T> : IParser<T>
    {
        public JsonParser()
        {
            
        }
        public IRepository<T> ParseDataToObject(List<T> inputData)
        {
            return new T(inputData);
        }
    }
}