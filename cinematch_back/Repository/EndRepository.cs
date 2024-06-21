using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Repository
{
    public class EndRepository : IEndRepository
    {
        private readonly CinematchDBContext _dbContext;
        public EndRepository(CinematchDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EndModel>> GetAll()
        {
            return await _dbContext.TBLEnd.ToListAsync();
        }

        public async Task<EndModel> GetById(int id)
        {
            return await _dbContext.TBLEnd.FirstOrDefaultAsync(x => x.IDEnd == id);
        }
    }
}
