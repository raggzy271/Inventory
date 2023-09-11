using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAL
{
    public class PurchaseOrder
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public double TotalAmount { get; set; }
    }
}
