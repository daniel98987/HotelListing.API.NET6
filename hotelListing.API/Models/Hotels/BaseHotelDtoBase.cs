using System.ComponentModel.DataAnnotations;

namespace hotelListing.API.Models.Hotels
{
    public abstract class BaseHotelDtoBase
    {
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
        [Required]
        public string Name { get; set; }
        public double? Rating { get; set; }
    }
}