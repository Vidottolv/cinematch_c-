using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface ITestRepository
    {
        Task<List<TestModel>> GetAll();
        Task<TestModel> GetById(int id);
    }
}
