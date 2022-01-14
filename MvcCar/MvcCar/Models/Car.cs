using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //dodane



namespace MvcCar.Models

{

    public class Car

    {

        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        [DataType(DataType.Date)] //we need Date only
        [Display(Name = "YearOfManufacture")] //dodane

        public DateTime YearOfManufacture { get; set; }

        public string FuelType { get; set; }
        [Column(TypeName = "decimal(18, 2)")] //dodane

        public decimal Price { get; set; }

    }

}