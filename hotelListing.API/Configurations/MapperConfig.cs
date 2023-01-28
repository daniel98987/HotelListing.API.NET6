using AutoMapper;
using hotelListing.API.Data;
using hotelListing.API.Models.Country;
using hotelListing.API.Models.Hotels;

namespace hotelListing.API.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreaateHotelDtoBase>().ReverseMap();
        }
    }
}
