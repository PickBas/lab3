using System.IO;
using lab3.FileWork.Services;

namespace lab3.FileWork.CSV
{
    public class CSVWriter<T> : IWriter<T>
    {
        public CSVWriter()
        {
        }

        public void Write(string filePath, IRepository<T> repository)
        {
            File.WriteAllText(filePath, repository.ToCsv());
        }
    }
}