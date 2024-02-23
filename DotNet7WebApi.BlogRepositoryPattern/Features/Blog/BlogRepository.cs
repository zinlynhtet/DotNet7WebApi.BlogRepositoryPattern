namespace DotNet7WebApi.BlogRepositoryPattern.Features.Blog;

public class BlogRepository : IBlogRepository
{
    private readonly AppDbContext _context;

    public BlogRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BlogDataModel>> GetAllBlogs()
    {
        return await _context.TblBlogs.AsNoTracking().ToListAsync();
    }

    public async Task<BlogResponseModel> GetBlogById(string id)
    {
        var item = await _context.TblBlogs
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        return new BlogResponseModel
        {
            IsSuccess = item is not null,
            Message = item is not null ? "Success" : "Blog was not found.",
            BlogData = item
        };
    }

    public async Task<BlogResponseModel> BlogCreate(BlogRequestModel requestModel)
    {
        var blog = new BlogDataModel
        {
            Id = Guid.NewGuid().ToString(),
            BlogTitle = requestModel.BlogTitle,
            BlogAuthor = requestModel.BlogAuthor,
            BlogContent = requestModel.BlogContent

        };
        await _context.TblBlogs.AddAsync(blog);
        var count = await _context.SaveChangesAsync();

        return new BlogResponseModel
        {
            IsSuccess = count > 0,
            Message = count > 0 ? "Blog created successfully" : "Blog creating failed.",
            BlogData = blog
        };
    }

    public async Task<BlogResponseModel> UpdateBlog(string id, BlogRequestModel requestModel)
    {
        var item = await _context.TblBlogs
            .FirstOrDefaultAsync(x => x.Id == id);
        if (item is null) goto result;
        item.BlogTitle = requestModel.BlogTitle;
        item.BlogAuthor = requestModel.BlogAuthor;
        item.BlogContent = requestModel.BlogContent;

        _context.TblBlogs.Update(item);
        result:
        var count = await _context.SaveChangesAsync();
        return new BlogResponseModel
        {
            IsSuccess = count > 0,
            Message = count > 0 ? "Update Successful." : "Blog was not found.",
            BlogData = item!
        };
    }

    public async Task<BlogResponseModel> DeleteBlog(string id)
    {
        var item = await _context.TblBlogs
            .FirstOrDefaultAsync(x => x.Id == id);
        if (item is null) goto result;
        _context.TblBlogs.Remove(item);
        result:
        var count = await _context.SaveChangesAsync();
        return new BlogResponseModel
        {
            IsSuccess = count > 0,
            Message = count > 0 ? "Deleting Successful." : "Blog was not found.",
            BlogData = item!
        };
    }
}