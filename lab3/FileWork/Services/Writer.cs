namespace lab3.FileWork.Services
{
    public interface IWriter<T>
    {
        void Write(string filePath, IRepository<T> repository);
    }
}