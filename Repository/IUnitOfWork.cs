namespace USSP.Repository
{
    public interface IUnitOfWork
    {
        void Commit(string userName);
    }
}
