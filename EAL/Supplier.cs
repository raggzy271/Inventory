using System.ComponentModel.DataAnnotations;

namespace EAL
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ContactPerson { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        public string Address { get; set; }
    }
}