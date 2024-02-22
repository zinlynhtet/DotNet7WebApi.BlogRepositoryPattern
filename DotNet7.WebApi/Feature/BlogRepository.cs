using DotNet7.WebApi.AppDbContextModels;
using DotNet7.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet7.WebApi.Feature
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _context;

        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TblBlog> BlogCreate(TblBlog requestModel)
        {
            requestModel.Id = Guid.NewGuid().ToString();
            var blog = await _context.TblBlogs.AddAsync(requestModel);
            return blog.Entity;
        }

        public async Task<IEnumerable<TblBlog>> GetAllBlogs()
        {
            return await _context.TblBlogs.ToListAsync();
        }

    }
}
