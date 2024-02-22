using DotNet7.WebApi.Models;

namespace DotNet7.WebApi.Feature
{
    public class BL_Blog
    {
        private readonly DA_Blog _dABlog;

        public BL_Blog(DA_Blog dABlog)
        {
            _dABlog = dABlog;
        }

        public async Task<BlogListResponseModel> GetBlogs()
        {
            return await _dABlog.BlogList();
        }
    }
}
