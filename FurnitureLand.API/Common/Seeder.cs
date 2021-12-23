using FurnitureLand.DatabaseMigration;
using FurnitureLand.Domain.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureLand.API.Common
{
    public static class Seeder
    {
        public static async Task SeedDefaultData(UserManager<Customers> userManager, AppDatabaseContext context)
        {
            await SeedDefaultCustomersAsync(userManager, context);
            await SeedDefaultInventoriesAsync(context);
        }

        public static async Task SeedDefaultCustomersAsync(UserManager<Customers> userManager, AppDatabaseContext context)
        {
            var existingUser = context.Users.FirstOrDefault();
            if (existingUser != null) return;

            Customers user1 = new Customers
            {
                Email = "corporate@gmail.com",
                UserName = "TestCorporateCustomer",
                CustomerTypes = context.CustomerTypes.Where(q => q.Name == "Corporate").FirstOrDefault(),
                Name = "NMB Bank",
                Fax = "092345674",
                Phone = "9843224567",
                Address = "BabarMahal, Kathmandu"
            };

            Customers user2 = new Customers
            {
                Email = "school@gmail.com",
                UserName = "TestSchoolCustomer",
                CustomerTypes = context.CustomerTypes.Where(q => q.Name == "Student").FirstOrDefault(),
                Name = "Umesh Shrestha",
                School = "Little Angels",
                Fax = "09234532",
                Phone = "9843224523",
                Address = "Hattiban, Kathmandu"
            };

            await userManager.CreateAsync(user1, "Test@123");
            await userManager.CreateAsync(user2, "Test@123");
        }

        public static async Task SeedDefaultInventoriesAsync(AppDatabaseContext context)
        {
            var existingInventories = context.Inventories.FirstOrDefault();
            if (existingInventories != null) return;

            Inventories inventory1 = new Inventories
            {
                Id = new Guid(),
                CustomerTypeId = context.CustomerTypes.Where(q => q.Name == "Corporate").FirstOrDefault().Id,
                Name = "Corporate Chair Inventory",
                CatalogId = context.Catalogs.Where(q => q.Name == "Chairs").FirstOrDefault().Id,
                Description = "Chair inventory for corporate users",
                FinishedProductSize = "36x36",
                FinishedProductWeight = "45"
            };

            await context.AddAsync(inventory1);

            CustomerInventories customerInventories = new CustomerInventories
            {
                Id = new Guid(),
                CustomerId = context.Users.Where(q => q.Email == "corporate@gmail.com").FirstOrDefault().Id,
                InventoryId = inventory1.Id
            };

            await context.AddAsync(customerInventories);

            InventoryAvailablilties inventoryAvailablilties1 = new InventoryAvailablilties
            {
                Id = new Guid(),
                IsAvailable = true,
                ColorId = context.Colors.Where(q => q.Name == "Red").FirstOrDefault().Id,
                MaterialId = context.Materials.Where(q => q.Name == "Pine").FirstOrDefault().Id,
                Price = 500,
                Quantity = 6
            };


            InventoryAvailablilties inventoryAvailablilties2 = new InventoryAvailablilties
            {
                Id = new Guid(),
                IsAvailable = true,
                ColorId = context.Colors.Where(q => q.Name == "Blue").FirstOrDefault().Id,
                MaterialId = context.Materials.Where(q => q.Name == "Milo").FirstOrDefault().Id,
                Price = 700,
                Quantity = 5
            };

            await context.AddAsync(inventoryAvailablilties1);
            await context.AddAsync(inventoryAvailablilties2);

            await context.SaveChangesAsync();
        }
    }
}
