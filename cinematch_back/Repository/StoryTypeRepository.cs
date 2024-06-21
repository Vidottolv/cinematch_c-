using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Repository
{
    public class StoryTypeRepository : IStoryTypeRepository
    {
        private readonly CinematchDBContext _dbContext;
        public StoryTypeRepository(CinematchDBContext DBContext)
        {
            _dbContext = DBContext;
        }
        public async Task<List<StoryTypeModel>> GetAll()
        {
            return await _dbContext.TBLStoryType.ToListAsync();
        }

        public async Task<StoryTypeModel> GetStoryTypeById(int id)
        {
            return await _dbContext.TBLStoryType.FirstOrDefaultAsync(x => x.IDStoryType == id);
        }
    }
}
