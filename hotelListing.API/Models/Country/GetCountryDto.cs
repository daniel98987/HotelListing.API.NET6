using hotelListing.API.Data;
using hotelListing.API.Models.Hotels;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotelListing.API.Models.Country
{
    public class GetCountryDto: BaseCountryDto
    {

        public int Id { get; set; }
    }    


}
