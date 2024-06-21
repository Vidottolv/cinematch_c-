using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IAgeRepository
    {
        Task<List<AgeModel>> GetAll();
        Task<AgeModel> GetById(int id);
    }
}
