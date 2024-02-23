namespace DotNet7WebApi.BlogRepositoryPattern.AppDbContextModels;

public partial class BlogDataModel
{
    public int BlogId { get; set; }

    public string Id { get; set; } = null!;

    public string? BlogTitle { get; set; }

    public string? BlogAuthor { get; set; }

    public string? BlogContent { get; set; }
}
public partial class BlogResponseModel
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public BlogDataModel BlogData { get; set; }
}

public partial class BlogRequestModel
{
    public string? BlogTitle { get; set; }

    public string? BlogAuthor { get; set; }

    public string? BlogContent { get; set; }
}
