using hotelListing.API.Contracts;
using hotelListing.API.Data;
using HotelListing.API.Repository;

namespace hotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext dbContext) : base(dbContext) { 
            
        
        }
    }
}
