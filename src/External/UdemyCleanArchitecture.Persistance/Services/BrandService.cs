using AutoMapper;
using UdemyCleanArchitecture.Application.Features.Brands.Create;
using UdemyCleanArchitecture.Application.Features.Brands.Queries;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Application.Result;
using UdemyCleanArchitecture.Application.Services;
using UdemyCleanArchitecture.Domain.Entities;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;

namespace UdemyCleanArchitecture.Persistance.Services;
internal class BrandService : IBrandService
{
    private readonly AppDbContext _context;
    private readonly IBrandRepository _brandRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BrandService(AppDbContext context, IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _context = context;
        _brandRepository = brandRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> CreateAsync(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        var brandIsExists = await _brandRepository.AnyAsync(c => c.Name == request.Name);
        if (brandIsExists)
        {
            return Result<string>.Failure("Bu marka zaten kayıtlı!");
        }
        var brand = _mapper.Map<Brand>(request);

        await _brandRepository.AddAsync(brand, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("Marka başarıyla kaydedildi!");
    }

    public async Task<PaginationResult<Brand>> GetAllAsync(GetAllBrandQuery request, CancellationToken cancellationToken)
    {
        var brands = await _brandRepository
            .GetWhere(b => b.Name.ToLower().Contains(request.Search.ToLower()))
            .OrderBy(b => b.Name)
            .ToPagedListAsync(request.PageNumber, request.PageSize, cancellationToken);
        return brands;
    }
}
