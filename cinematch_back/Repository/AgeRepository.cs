using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Repository
{
    public class AgeRepository : IAgeRepository
    {
        private readonly CinematchDBContext _dbContext;
        public AgeRepository(CinematchDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<AgeModel>> GetAll()
        {
            return await _dbContext.TBLAge.ToListAsync();
        }

        public async Task<AgeModel> GetById(int id)
        {
            return await _dbContext.TBLAge.FirstOrDefaultAsync(x => x.IDAge == id);
        }
    }
}
