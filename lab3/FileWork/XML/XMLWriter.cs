using System.IO;
using lab3.FileWork.Services;

namespace lab3.FileWork.XML
{
    public class XMLWriter<T> : IWriter<T>
    {
        public XMLWriter()
        {
        }
        
        public void Write(string filePath, IRepository<T> repository)
        {
            File.WriteAllText(filePath, repository.ToXml());
        }
        
    }
}