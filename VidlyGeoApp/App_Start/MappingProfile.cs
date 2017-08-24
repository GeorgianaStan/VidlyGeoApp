using AutoMapper;
using VidlyGeoApp.Dtos;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domenin to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MemebershipTypeDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MemebershipTypeDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            
        }
    }
}