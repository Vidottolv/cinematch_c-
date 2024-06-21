using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace cinematch_back.Repository
{
    public class KindRepository : IKindRepository
    {
        private readonly CinematchDBContext _dbContext;
        public KindRepository(CinematchDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<KindModel>> GetAll()
        {
            return await _dbContext.TBLKind.ToListAsync();
        }

        public async Task<KindModel> GetKindById(int id)
        {
            return await _dbContext.TBLKind.FirstOrDefaultAsync(x => x.IDKind == id);
        }
    }
}
