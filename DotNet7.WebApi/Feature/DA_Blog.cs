using DotNet7.WebApi.AppDbContextModels;
using DotNet7.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet7.WebApi.Feature
{
    public class DA_Blog
    {
        private readonly AppDbContext _context;

        public DA_Blog(AppDbContext context)
        {
            _context = context;
        }
        //public async Task<BlogListResponseModel> BlogList()
        //{
        //    var model = new BlogListResponseModel();
        //    var blogs = await _context.TblBlogs
        //        .AsNoTracking()
        //        .Select(x => new TblBlog()
        //        {
        //            BlogId = x.BlogId,
        //            Id = x.Id,
        //            BlogTitle = x.BlogTitle,
        //            BlogAuthor = x.BlogAuthor,
        //            BlogContent = x.BlogContent,
        //        })
        //        .ToListAsync();

        //    model.Blogs = blogs;
        //    return model;
        //}
        public async Task<BlogResponseModel> BlogCreate(BlogRequestModel requestModel)
        {
            var model = new BlogResponseModel();
            var blog = new TblBlog()
            {
                Id = Guid.NewGuid().ToString(),
                BlogTitle = requestModel.BlogTitle,
                BlogAuthor = requestModel.BlogAuthor,
                BlogContent = requestModel.BlogContent,
            };
            _context.TblBlogs.Add(blog);
            var result = await _context.SaveChangesAsync();
            model.IsSuccess = result > 0;
            model.Message = model.IsSuccess ? "Blog created successfully" : "Failed to create blog";

            if (model.IsSuccess)
            {
                model.BlogData = new BlogViewModel
                {
                    Id = blog.Id,
                    BlogTitle = blog.BlogTitle,
                    BlogAuthor = blog.BlogAuthor,
                    BlogContent = blog.BlogContent,
                };
            }
            return model;
        }
    }
}
