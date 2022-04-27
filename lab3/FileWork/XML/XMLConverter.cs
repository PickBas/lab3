using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace lab3.FileWork.XML
{
    public class XMLConverter : Converter
    {
        public XMLConverter()
        {
            
        }
        
        public string convert(TestResults testResults)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(testResults.getParticipants().GetType());
            using(StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, testResults.getParticipants());
                return textWriter.ToString();
            }
        }
    }
}