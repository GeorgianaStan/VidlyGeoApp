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
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            
        }
    }
}