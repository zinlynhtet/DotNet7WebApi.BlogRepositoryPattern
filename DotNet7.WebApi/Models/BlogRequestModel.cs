using DotNet7.WebApi.AppDbContextModels;

namespace DotNet7.WebApi.Models
{
    public class BlogRequestModel
    {
        public string Id { get; set; }

        public string? BlogTitle { get; set; }

        public string? BlogAuthor { get; set; }

        public string? BlogContent { get; set; }
    }

    //public class BlogResponseModel
    //{
    //    public bool IsSuccess { get; set; }
    //    public string Message { get; set; }
    //    public TblBlog BlogData { get; set; }
    //}
}
