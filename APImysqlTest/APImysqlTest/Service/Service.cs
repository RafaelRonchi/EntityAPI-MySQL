using APImysqlTest.Data;
using APImysqlTest.Model;
using Microsoft.EntityFrameworkCore;

namespace APImysqlTest.Service
{
    public class Service : IService
    {
        private readonly MyDbContext _context;

        public Service(MyDbContext context)
        {
            _context = context;
        }

        public async Task<testCsharp> create(testCsharp t)
        {
            _context.testcrud.Add(t);
            await _context.SaveChangesAsync();

            return t;
        }

        public async Task<bool> delete(int id)
        {
            var exist = _context.testcrud.FirstOrDefault(t => t.id == id);
            if (exist != null)
            {
                _context.testcrud.Remove(exist);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<List<testCsharp>> getAll()
        {
            return await _context.testcrud.ToListAsync();
        }

        public async Task<testCsharp> update(testCsharp t)
        {
            var exist = _context.testcrud.FirstOrDefault(t=>t.id == t.id);
            if (exist != null)
            {
                exist.name = t.name;
                _context.Update(exist);
                await _context.SaveChangesAsync();

                return t;
            }
            else
            {
                return null;
            }
        }
    }
}
