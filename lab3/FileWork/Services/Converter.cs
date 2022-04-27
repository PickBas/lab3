namespace lab3.FileWork.Services
{
    public interface IConverter<T>
    {
        string Convert(IRepository<T> repository);
    }
}