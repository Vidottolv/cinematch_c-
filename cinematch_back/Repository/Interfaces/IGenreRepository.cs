using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<GenreModel>> GetAllGenres();
        Task<GenreModel> GetGenreById(int id);
    }
}
