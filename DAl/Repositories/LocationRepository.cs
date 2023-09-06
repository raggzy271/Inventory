using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public LocationRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddLocation(Location location)
        {
            _inventoryDbContext.location.Add(location);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateLocation(Location location)
        {
            _inventoryDbContext.Entry(location).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteLocation(int id)
        {
            var location = _inventoryDbContext.location.Find(id);
            if (location != null)
            {
                _inventoryDbContext.location.Remove(location);
                _inventoryDbContext.SaveChanges();
            }
        }

        public Location? GetLocation(int id)
        {
            return _inventoryDbContext.location.Find(id);
        }

        public List<Location> GetAllLocations()
        {
            return _inventoryDbContext.location.ToList();
        }
    }
}