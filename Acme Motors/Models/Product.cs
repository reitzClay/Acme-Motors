using System.ComponentModel.DataAnnotations;

namespace Acme_Motors.Models
{
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /**
        [Required, StringLength(3), Display(Name = "Rust Damage"), DataType(DataType.MultilineText)]
        public string HasRustDamage { get; set; }

        [Required, StringLength(3), Display(Name = "Wind Visor"), DataType(DataType.MultilineText)]
        public string HasWindVisor { get; set; }

        [Required, StringLength(6), Display(Name = "Fuel Type"), DataType(DataType.MultilineText)]
        public string FuelType { get; set; }

        [Required, StringLength(1000), Display(Name = "Model"), DataType(DataType.MultilineText)]
        public string Model { get; set; }

        [Required, StringLength(1000), Display(Name = "Year"), DataType(DataType.MultilineText)]
        public string Year { get; set; }

        [Required, StringLength(1000), Display(Name = "Color"), DataType(DataType.MultilineText)]
        public string Color { get; set; }

        [Required, StringLength(1000), Display(Name = "Engine cc Size"), DataType(DataType.MultilineText)]
        public string Size { get; set; }

        public string ImagePath { get; set; }
        [Display(Name = "Price")]

        public int? EngineId { get; set; }

        public int? QuantityInStock { get; set; }

        public int? NumberOfWheels { get; set; }

        public double? MaximumLoad { get; set; }

        public double? Mileage { get; set; }
        */

        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        [EnumDataType(typeof(VehicleType)), Display(Name = "Type of Vehicle")]
        public VehicleType Vehicle { get; set; }
    }
}