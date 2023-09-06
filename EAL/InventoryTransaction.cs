using System.ComponentModel.DataAnnotations;

namespace EAL
{
    public enum Type
    {
        IN, OUT
    }

    public class InventoryTransaction
    {
        [Key]
        public int Id { get; set; }

        public InventoryItem InventoryItem { get; set; }

        public Warehouse Warehouse { get; set; }

        public string TypeString { get; set; }

        public Type Type { get; set; }

        public Location ItemLocation { get; set; }

        public string FormattedLocation { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
