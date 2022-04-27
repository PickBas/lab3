using System.IO;
using lab3.FileWork.Services;

namespace lab3.FileWork.JSON
{
    public class JsonWriter<T> : IWriter<T>
    {
        public JsonWriter()
        {
        }

        public void Write(string filePath, IRepository<T> repository)
        {
            File.WriteAllText(filePath, repository.ToJson());
        }
    }
}