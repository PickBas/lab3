using DocumentFormat.OpenXml.Office2010.CustomUI;
using lab3.FileWork.Services;
using ServiceStack.Text;

namespace lab3.FileWork.CSV
{
    public class CSVConverter<T> : IConverter<T>
    {
        public CSVConverter()
        {
            
        }

        public string Convert(IRepository<T> testResults)
        {
            return CsvSerializer.SerializeToCsv(testResults.getParticipants());
        }
    }
}