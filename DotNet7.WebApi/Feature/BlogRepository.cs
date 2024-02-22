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
        public async Task<IEnumerable<TblBlog>> GetAllBlogs()
        {
            return await _context.TblBlogs.ToListAsync();
        }
        //public async Task BlogCreate(BlogRequestModel requestModel)
        //{

        //    return await _context.TblBlogs.AddAsync(requestModel);
        //}
    }
}
