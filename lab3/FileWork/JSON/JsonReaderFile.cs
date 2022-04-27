using System;
using System.Collections.Generic;
using System.IO;
using lab3.FileWork.Services;
using Newtonsoft.Json;

namespace lab3.FileWork.JSON
{
    public class JsonReaderFile<T> : IReader<T>
    {
        public JsonReaderFile()
        {
        }

        public List<T> GetStudentData(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}