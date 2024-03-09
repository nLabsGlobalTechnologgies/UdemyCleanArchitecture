using UdemyCleanArchitecture.Domain.Entities;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;

namespace UdemyCleanArchitecture.Persistance.Repositories;
public sealed class ModelRepository : Repository<Model, AppDbContext>, IModelRepository
{
    public ModelRepository(AppDbContext context) : base(context) {}
}
