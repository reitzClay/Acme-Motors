using System.Data.Entity;

namespace Acme_Motors.Models
{
    public class ProductContext : DbContext
    {
       /*public ProductContext() : base("BaseTable")
        {

        }*/
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    public enum VehicleType
    {
        Car,
        Motorbike,
        Truck
    }
}