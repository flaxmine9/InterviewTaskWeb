using AutoMapper;
using InterviewTaskWeb.DataBase.Models;
using InterviewTaskWeb.DTOModels;

namespace InterviewTaskWeb
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>();
            CreateMap<CreateCompanyDto, Company>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();

            CreateMap<Otdel, OtdelDto>();
            CreateMap<CreateOtdelDto, Otdel>();

            CreateMap<Department, DepartmentDto>()
                .ForMember(dest => dest.Otdels, opt => opt.MapFrom(src => src.Otdels));

            CreateMap<Company, CompanyDto>()
                .ForMember(dest => dest.Departments, opt => opt.MapFrom(src => src.Departments));
        }
    }
}