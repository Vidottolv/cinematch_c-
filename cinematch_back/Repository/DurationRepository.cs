using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace cinematch_back.Repository
{
    public class DurationRepository : IDurationRepository
    {
        private readonly CinematchDBContext _dbContext;
        public DurationRepository(CinematchDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DurationModel>> GetAll()
        {
            return await _dbContext.TBLDurationMovie.ToListAsync();
        }

        public async Task<DurationModel> GetById(int id)
        {
            return await _dbContext.TBLDurationMovie.FirstOrDefaultAsync(x => x.IDDuration == id);
        }
    }
}
