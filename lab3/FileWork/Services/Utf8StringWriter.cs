using System.IO;
using System.Text;

namespace lab3.FileWork.Services
{
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}