using Microsoft.EntityFrameworkCore;
using UdemyCleanArchitecture.Domain.Repositories;

namespace UdemyCleanArchitecture.Persistance.Repositories;
public sealed class UnitOfWork<Context> : IUnitOfWork
    where Context : DbContext
{
    private readonly Context _context;

    public UnitOfWork(Context context)
    {
        _context = context;
    }

    public int SaveChanges()
    {
        _context.SaveChanges();
        return 1;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
        return 1;
    }
}
