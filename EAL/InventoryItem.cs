using System.ComponentModel.DataAnnotations;

namespace EAL
{
    public class InventoryItem

    {
        [Key]
        public int Id { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public int BeginningQuantity { get; set; }

        public bool IsAvailable { get; set; }

        public double ItemPrice { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}