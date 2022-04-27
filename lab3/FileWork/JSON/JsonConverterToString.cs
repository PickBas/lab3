using System.Collections.Generic;
using lab3.FileWork.Services;
using Newtonsoft.Json;

namespace lab3.FileWork.JSON
{
    public class JsonConverterToString<T> : IConverter<T>
    {
        public JsonConverterToString()
        {
            
        }
        public string Convert(List<T> data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}