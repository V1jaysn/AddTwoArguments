

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TwoArgumentsProj.Data.DbContexts;

public class ArgumentDbContextFactory: IDesignTimeDbContextFactory<ArgumentDbContext>
{
    public ArgumentDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ArgumentDbContext>();
        optionsBuilder.UseSqlServer("Server=US-LL-PC0GMT9A\\SQLEXPRESS;Database=ArgumentsDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        return new ArgumentDbContext(optionsBuilder.Options);
    }

}
