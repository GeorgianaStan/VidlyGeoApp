using AutoMapper;
using VidlyGeoApp.Dtos;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}