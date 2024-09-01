namespace System.Core.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);


        Task AddAsync(T item);

        void Update(T item);
    }
}
