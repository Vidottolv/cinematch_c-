using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IKindRepository
    {
        Task<List<KindModel>> GetAll();
        Task<KindModel> GetKindById(int id);
    }
}
