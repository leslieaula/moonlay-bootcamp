namespace LearnCSharp.Membership.Interfaces
{
    public interface IDeleteByIdAble<T>
    {
        T DeleteById(int id);
    }
}
