using System.Collections.Generic;
using lab3.FileWork.JSON;
using lab3.FileWork.XML;

namespace lab3.FileWork.Services
{
    public class ReadDataObj<T>
    {
        private static List<T> ReadData(string extension, string filePath)
        {
            switch (extension)
            {
                case string a when a.Contains("json"):
                    IReader<T> reader = new JsonReaderFile<T>();
                    return reader.GetData(filePath);
                case string a when a.Contains("xml"):
                    IReader<T> reader = new JsonReaderFile<T>();
                    return reader.GetData(filePath);
                case string a when a.Contains("csv"):
                    reader = new CSVReader();
                    parser = new CSVParser();
                    _testResults.setParticipants(
                        parser.parseDataToTestResult(
                            reader.getStudentData(filePath)
                        ).getParticipants());
                    break;
            }
        }
    }
}