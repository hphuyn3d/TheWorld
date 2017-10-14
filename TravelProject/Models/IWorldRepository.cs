using System.Collections.Generic;

namespace TravelProject.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
    }
}