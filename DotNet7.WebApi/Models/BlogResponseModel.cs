using DotNet7.WebApi.AppDbContextModels;

namespace DotNet7.WebApi.Models;
public class BlogResponseModel
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public BlogViewModel BlogData { get; set; }
}

public class BlogListResponseModel
{
    public bool IsSuccess { get; set; }
    public List<TblBlog> Blogs { get; set; }
}