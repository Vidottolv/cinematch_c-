using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly TestDBContext _dbContext;
        public TestRepository(TestDBContext testDBContext)
        { 
            _dbContext = testDBContext;
        }
        public async Task<List<TestModel>> GetAll()
        {
            return await _dbContext.TBLTestes.ToListAsync();
        }

        public async Task<TestModel> GetById(int id)
        {
            return await _dbContext.TBLTestes.FirstOrDefaultAsync(x => x.IDTest == id);
        }
    }
}
