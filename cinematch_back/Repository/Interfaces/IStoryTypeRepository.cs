using cinematch_back.Models;

namespace cinematch_back.Repository.Interfaces
{
    public interface IStoryTypeRepository
    {
        Task<List<StoryTypeModel>> GetAll();
        Task<StoryTypeModel> GetStoryTypeById(int id);
    }
}
