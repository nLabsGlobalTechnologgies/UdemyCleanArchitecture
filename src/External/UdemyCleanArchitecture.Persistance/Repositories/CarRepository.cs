using UdemyCleanArchitecture.Domain.Entities;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;

namespace UdemyCleanArchitecture.Persistance.Repositories;
public sealed class CarRepository : Repository<Car, AppDbContext>, ICarRepository
{
    public CarRepository(AppDbContext context) : base(context)
    {
    }
}
