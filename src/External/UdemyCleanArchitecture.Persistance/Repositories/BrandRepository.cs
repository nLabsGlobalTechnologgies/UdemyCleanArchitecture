using UdemyCleanArchitecture.Domain.Entities;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;

namespace UdemyCleanArchitecture.Persistance.Repositories;
public sealed class BrandRepository : Repository<Brand, AppDbContext>, IBrandRepository
{
    public BrandRepository(AppDbContext context) : base(context) {}
}
