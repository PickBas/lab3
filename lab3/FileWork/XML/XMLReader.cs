using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using lab3.FileWork.Services;

namespace lab3.FileWork.XML
{
    public class XMLReader<T> : IReader<T>
    {
        public XMLReader()
        {
            
        }
        
        public List<T> GetData(string filePath)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<T>));
            List<T> entities = new List<T>();
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                entities = (List<T>) ser.Deserialize(reader);
            }
            return entities;
        }
    }
}