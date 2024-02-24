<h2>
﻿What is repository pattern?	
</h2>
The Repository Pattern is a design pattern commonly used in software development, including ASP.NET Core applications,
to abstract the data access logic and provide a clean separation between the application's business logic and the underlying data storage mechanisms.
It's a way to centralize and organize the data access code in a dedicated layer, making the codebase more maintainable, scalable, and testable.

<img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Smilies/Ghost.png" alt="Ghost" width="25" height="25" />
<img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Smilies/Ghost.png" alt="Ghost" width="25" height="25" />
<img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Smilies/Ghost.png" alt="Ghost" width="25" height="25" />
<img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Smilies/Ghost.png" alt="Ghost" width="25" height="25" />
<img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Smilies/Ghost.png" alt="Ghost" width="25" height="25" />
﻿

>Code first မဟုတ်ပဲ Db first command ,Scaffold db command line run ပြီး DbContext Model ဆောက်ထားတာဖြစ်ပါတယ်။
Db services ကို  Solution Layer မှာ Class Library တစ်ခုသုံးပြီး Project Reference ပြန်ယူကာအသုံးပြုထားပါတယ်။ 
ရည်ရွယ်ချက်ကတော့ Scaffold command ပြန် run ဖို့လိုလာတိုင်း အလွယ်တကူ run လို့ရအောင်ပါ။
Api test လုပ်ဖို့ဆိုရင် MSSql db query ကို အရင်ဆုံး runပေးရပါမယ်။ 
ပြီးလျှင် မိမိ computer ရဲ့ Db Connection String ကို appsetting.jsonမှာပြောင်းပေးရပါမယ်။ 
Now, you're good to go on.
To clone the git repository, run thi command in cmd
```
cd your folder path
git clone https://github.com/zinlynhtet/DotNet7WebApi.BlogRepositoryPattern.git
```
For Mssql database, run this query
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
Scaffold command line 
```bash
dotnet ef dbcontext scaffold "Server=.;Database=TestDb;User Id=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o AppDbContextModels -c AppDbContext -t BlogDataModel -f

```
You can read more information about this pattern [here](https://code-maze.com/net-core-web-development-part4/).
