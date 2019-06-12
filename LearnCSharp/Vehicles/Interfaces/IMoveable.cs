namespace LearnCSharp.Vehicles.Interfaces
{
    public interface IMoveable<T>
    {
        T Move(int rpm);
        T Stop();
    }
}
