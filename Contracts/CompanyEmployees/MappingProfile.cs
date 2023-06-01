using AutoMapper;
using Shared;
using System.Linq;
using Entities.Models;



public class MappingProfile : Profile
{
    public MappingProfile()
    {
       CreateMap<Company, CompanyDto>()
.ForMember(c => c.FullAddress,
opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

        CreateMap<Employee, EmployeeDto>();
        CreateMap<CompanyForCreationDto, Company>();
        CreateMap<CompanyForUpdateDto, Company>();


        CreateMap<EmployeeForCreationDto, Employee>();
        CreateMap<EmployeeForUpdateDto, Employee>();
        CreateMap<EmployeeForUpdateDto, Employee>();
        CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

        CreateMap<UserForRegistrationDto, User>();





    }

}