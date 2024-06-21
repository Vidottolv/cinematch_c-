using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<GenreModel>> GetAll();
        Task<GenreModel> GetGenreById(int id);
    }
}
