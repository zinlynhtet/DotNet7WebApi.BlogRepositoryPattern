```bash
dotnet ef dbcontext scaffold "Server=.;Database=TestDb;User Id=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o AppDbContextModels -c AppDbContext -t BlogDataModel -f

```

```sql
USE [TestDb]
GO
/****** Object:  Table [dbo].[Tbl_Blogs]    Script Date: 2/23/2024 8:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Blogs](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](50) NOT NULL,
	[BlogTitle] [nvarchar](50) NULL,
	[BlogAuthor] [nvarchar](50) NULL,
	[BlogContent] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_Blogs] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Blogs] ON 

INSERT [dbo].[Tbl_Blogs] ([BlogId], [Id], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (2, N'9fb72f8a-e257-4d74-b082-0549fb898721', N'PutTest', N'PutTest', N'PutTest')
INSERT [dbo].[Tbl_Blogs] ([BlogId], [Id], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (3, N'c6556c4a-9657-4276-b66f-710983c16ff9', N'string', N'string', N'string')
INSERT [dbo].[Tbl_Blogs] ([BlogId], [Id], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (4, N'055fae1d-62aa-4678-abd9-361d8fa322a1', N'hello', N'hello', N'hello')
SET IDENTITY_INSERT [dbo].[Tbl_Blogs] OFF
GO

```