namespace LearnCSharp.Membership.Interfaces
{
    public interface IReadByIdAble<T>
    {
        T ReadById(int id);
    }
}
