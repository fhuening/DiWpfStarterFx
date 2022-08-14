namespace DiWpfStarter.Helper
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}