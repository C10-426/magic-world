

public interface IManager<T> : IFactory<T>
{

    void Remove(int id);

    T Find(int id);

    T FindOrCreate(int id);
}