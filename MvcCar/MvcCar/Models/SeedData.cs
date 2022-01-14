using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCar.Data;
using System;
using System.Linq;
namespace MvcCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCarContext>>()))
            {
                // Look for any cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }
                context.Car.AddRange(
                    new Car
                    {
                        Brand = "Volkswagen",
                        Model = "Taigo",
                        YearOfManufacture = DateTime.Parse("2022-1-1"),
                        FuelType = "Petrol",
                        Price = 110000M
                    },
                    new Car
                    {
                        Brand = "Volkswagen",
                        Model = "Passat 1.6",
                        YearOfManufacture = DateTime.Parse("2019-1-1"),
                        FuelType = "Diesel",
                        Price = 141000M
                    },
                    new Car
                    {
                        Brand = "Jeep",
                        Model = "Wrangler",
                        YearOfManufacture = DateTime.Parse("2019-1-1"),
                        FuelType = "Petrol",
                        Price = 195000M
                    },
                    new Car
                    {
                        Brand = "Ford",
                        Model = "Mondeo 2.0",
                        YearOfManufacture = DateTime.Parse("2002-1-1"),
                        FuelType = "Diesel",
                        Price = 4950M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}