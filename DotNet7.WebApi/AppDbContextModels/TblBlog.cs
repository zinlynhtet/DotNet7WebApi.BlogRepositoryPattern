using System;
using System.Collections.Generic;

namespace DotNet7.WebApi.AppDbContextModels;

public partial class TblBlog
{
    public int BlogId { get; set; }

    public string Id { get; set; } = null!;

    public string? BlogTitle { get; set; }

    public string? BlogAuthor { get; set; }

    public string? BlogContent { get; set; }
}
