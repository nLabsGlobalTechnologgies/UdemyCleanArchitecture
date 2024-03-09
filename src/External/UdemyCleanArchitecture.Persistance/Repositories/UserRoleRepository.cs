using UdemyCleanArchitecture.Domain.Entities;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;

namespace UdemyCleanArchitecture.Persistance.Repositories;
public sealed class UserRoleRepository : Repository<UserRole, AppDbContext>, IUserRoleRepository
{
    public UserRoleRepository(AppDbContext context) : base(context)
    {
    }
}
