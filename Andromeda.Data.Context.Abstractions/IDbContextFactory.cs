namespace Andromeda.Data.Context.Abstractions
{
    public interface IDbContextFactory<TDbContext>
        where TDbContext : IDbContext
    {
        TDbContext CreateDbContext(string[] args);
    }
}
