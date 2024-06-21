using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IEndRepository
    {
        Task<List<EndModel>> GetAll();
        Task<EndModel> GetById(int id);
    }
}
