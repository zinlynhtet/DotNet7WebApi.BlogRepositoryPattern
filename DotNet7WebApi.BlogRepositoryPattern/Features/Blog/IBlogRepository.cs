namespace DotNet7WebApi.BlogRepositoryPattern.Features.Blog;

public interface IBlogRepository
{
    Task<IEnumerable<BlogDataModel>> GetAllBlogs();
    Task<BlogResponseModel> GetBlogById(string id);
    Task<BlogResponseModel> BlogCreate(BlogRequestModel requestModel);
    Task<BlogResponseModel> UpdateBlog(string id, BlogRequestModel requestModel);
    Task<BlogResponseModel> DeleteBlog(string id);
}