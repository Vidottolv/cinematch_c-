using cinematch_back.Data;
using cinematch_back.Models;
using cinematch_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly GenreDBContext _dbContext;
        public GenreRepository(GenreDBContext genreDBContext)
        {
            _dbContext = genreDBContext;
        }
        public async Task<List<GenreModel>> GetAllGenres()
        {
            return await _dbContext.TBLGenres.ToListAsync();
        }

        public async Task<GenreModel> GetGenreById(int id)
        {
            return await _dbContext.TBLGenres.FirstOrDefaultAsync(x => x.IDGenre == id);
        }
    }
}
