using AutoMapper;
using UdemyCleanArchitecture.Application.Features.Brands.Create;
using UdemyCleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using UdemyCleanArchitecture.Application.Features.Cars.Queries.GetAll;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Persistance.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBrandCommand, Brand>().ReverseMap();


        CreateMap<CreateCarCommand, Car>().ReverseMap();
        CreateMap<GetAllCarQuery, Car>().ReverseMap();
    }
}
