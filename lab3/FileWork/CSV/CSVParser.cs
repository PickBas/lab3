using System.Collections.Generic;
using lab3.FileWork.Services;

namespace lab3.FileWork.CSV
{
    public class CSVParser : IParser<>
    {
        public CSVParser()
        {
            
        }

        public TestResults parseDataToTestResult(List<Student> inputData)
        {
            return new TestResults(inputData);
        }
    }
}