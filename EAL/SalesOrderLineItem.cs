using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAL
{
    public class SalesOrderLineItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SalesOrder")]
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int QuantitySold { get; set; }

        public double UnitPrice { get; set; }

    }
}
