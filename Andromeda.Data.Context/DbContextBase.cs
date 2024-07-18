using Andromeda.Data.Context.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace Andromeda.Data.Context
{
    public class DbContextBase : DbContext, IDbContext
    {
        protected DbContextBase() : base()
        {
        }

        public DbContextBase(DbContextOptions options) : base(options)
        {
        }

        public IDbContextTransaction BeginTransaction()
            => Database.BeginTransaction();

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
            => Database.BeginTransactionAsync(cancellationToken);

        public bool CanConnect()
            => Database.CanConnect();

        public Task<bool> CanConnectAsync(CancellationToken cancellationToken = default)
            => Database.CanConnectAsync(cancellationToken);

        public void CommitTransaction()
            => Database.CommitTransaction();

        public Task CommitTransactionAsync(CancellationToken cancellationToken = default)
            => Database.CommitTransactionAsync(cancellationToken);

        public void RollbackTransaction()
            => Database.RollbackTransaction();

        public Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
            => Database.RollbackTransactionAsync(cancellationToken);
    }
}
