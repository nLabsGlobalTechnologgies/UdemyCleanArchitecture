using AutoMapper;
using UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using UdemyCleanArchitecture.Application.Features.Cars.Queries.GetAll;
using UdemyCleanArchitecture.Application.Pagination;
using UdemyCleanArchitecture.Application.Result;
using UdemyCleanArchitecture.Application.Services;
using UdemyCleanArchitecture.Domain.Entities;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;

namespace UdemyCleanArchitecture.Persistance.Services;
public sealed class CarService : ICarService
{
    private readonly AppDbContext _context;
    private readonly ICarRepository _carRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CarService(AppDbContext context, ICarRepository carRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _context = context;
        _carRepository = carRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<string>> CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        var carIsExists = await _carRepository.AnyAsync(c => c.Name == request.Name);
        if (carIsExists)
        {
            return Result<string>.Failure("Araç zaten kayıtlı!");
        }

        var car = _mapper.Map<Car>(request);

        await _carRepository.AddAsync(car, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("Araç başarıyla kaydedildi!");
    }

    public async Task<PaginationResult<Car>> GetAllAsync(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        var cars = await _carRepository.GetWhere(c => c.Name.ToLower().Contains(request.Search.ToLower()))
            .OrderBy(c => c.Name)
            .ToPagedListAsync(request.PageNumber, request.PageSize, cancellationToken);
        return cars;
    }
}
