using EAL;

namespace DAL.Repositories
{
    public interface ILocationRepository
    {
        public void AddLocation(Location location);

        public void UpdateLocation(Location location);

        public void DeleteLocation(int id);

        public Location? GetLocation(int id);

        public List<Location> GetAllLocations();
    }
}