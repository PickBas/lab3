using System.Collections.Generic;
using lab3.FileWork.Services;

namespace lab3.FileWork.XML
{
    public class XMLParser : IParser<>
    {
        public XMLParser()
        {
            
        }
        
        public TestResults parseDataToTestResult(List<Student> inputData)
        {
            return new TestResults(inputData);
        }
    }
}