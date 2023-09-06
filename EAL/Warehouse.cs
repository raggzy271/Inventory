using System.ComponentModel.DataAnnotations;

namespace EAL
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
