using APImysqlTest.Model;

namespace APImysqlTest.Service
{
    public interface IService
    {
        Task<testCsharp> create(testCsharp t);
        Task<testCsharp> update(testCsharp t);
        Task<bool> delete(int id);
        Task<List<testCsharp>> getAll();
    }
}
