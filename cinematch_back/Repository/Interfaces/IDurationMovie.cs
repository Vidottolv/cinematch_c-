using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IDurationMovie
    {
        Task<List<DurationModel>> GetAll();
        Task<DurationModel> GetById(int id);
    }
}
