using System.ComponentModel.DataAnnotations;

namespace EAL
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Category { get; set; }

        public double UnitPrice { get; set; }

        public int QuantityInStock { get; set; }
    }
}