using DotNet7.WebApi.AppDbContextModels;
using DotNet7.WebApi.Models;

namespace DotNet7.WebApi.Feature
{
    public interface IBlogRepository
    {
        //Task BlogCreate(BlogRequestModel requestModel);
        Task<IEnumerable<TblBlog>> GetAllBlogs();

    }
}
