```bash
dotnet ef dbcontext scaffold "Server=.;Database=TestDb;User Id=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o AppDbContextModels -c AppDbContext -t BlogDataModel -f

```