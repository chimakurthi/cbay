namespace Cbay.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository CreateRepository()
        {
            return new Repository();
        }
    }
}
