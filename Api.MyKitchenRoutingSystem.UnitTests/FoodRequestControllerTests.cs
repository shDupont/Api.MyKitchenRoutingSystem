using Api.MyKitchenRoutingSystem.BLL;
using Api.MyKitchenRoutingSystem.MOD;
using System;
using Xunit;
using FakeItEasy;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Api.MyKitchenRoutingSystem.UnitTests
{
    public class FoodRequestControllerTests
    {
        
        [Fact]
        public void GetFries_Returns_Only_Fries()
        {
            var options = new DbContextOptionsBuilder<TodoContextBLL>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo")
           .Options;

            using (var context = new TodoContextBLL(options))
            {
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 1, Name = "French Fries", Type = FoodTypeMOD.Fries });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 2, Name = "Pudim", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 3, Name = "Coke", Type = FoodTypeMOD.Drink });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 4, Name = "Ice Cream", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 5, Name = "Meat", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 6, Name = "Bacon", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 7, Name = "Caesar Salad", Type = FoodTypeMOD.Salad });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 8, Name = "Nuggets", Type = FoodTypeMOD.Fries });
                context.SaveChanges();
            }
            
            using (var context = new TodoContextBLL(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> fries = foodRequests.GetFriesBLL();

                Assert.Equal(2, fries.Count());
            }
            
        }

        [Fact]
        public void GetGrills_Returns_Only_Grills()
        {
            var options = new DbContextOptionsBuilder<TodoContextBLL>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Grills")
           .Options;

            using (var context = new TodoContextBLL(options))
            {
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 1, Name = "French Fries", Type = FoodTypeMOD.Fries });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 2, Name = "Pudim", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 3, Name = "Coke", Type = FoodTypeMOD.Drink });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 4, Name = "Ice Cream", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 5, Name = "Meat", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 6, Name = "Bacon", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 7, Name = "Caesar Salad", Type = FoodTypeMOD.Salad });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 8, Name = "Nuggets", Type = FoodTypeMOD.Fries });
                context.SaveChanges();
            }

            using (var context = new TodoContextBLL(options))
            {

                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> grills = foodRequests.GetGrillsBLL();

                Assert.Equal(2, grills.Count());
            }
        }

        [Fact]
        public void GetDrinks_Returns_Only_Drinks()
        {
            var options = new DbContextOptionsBuilder<TodoContextBLL>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Drinks")
           .Options;

            using (var context = new TodoContextBLL(options))
            {
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 1, Name = "French Fries", Type = FoodTypeMOD.Fries });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 2, Name = "Pudim", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 3, Name = "Coke", Type = FoodTypeMOD.Drink });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 4, Name = "Ice Cream", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 5, Name = "Meat", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 6, Name = "Bacon", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 7, Name = "Caesar Salad", Type = FoodTypeMOD.Salad });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 8, Name = "Nuggets", Type = FoodTypeMOD.Fries });
                context.SaveChanges();
            }


            using (var context = new TodoContextBLL(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> drinks = foodRequests.GetDrinksBLL();

                Assert.Equal(1, drinks.Count());
            }
        }

        [Fact]
        public void GetDeserts_Returns_Only_Deserts()
        {
            var options = new DbContextOptionsBuilder<TodoContextBLL>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Deserts")
           .Options;

            using (var context = new TodoContextBLL(options))
            {
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 1, Name = "French Fries", Type = FoodTypeMOD.Fries });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 2, Name = "Pudim", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 3, Name = "Coke", Type = FoodTypeMOD.Drink });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 4, Name = "Ice Cream", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 5, Name = "Meat", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 6, Name = "Bacon", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 7, Name = "Caesar Salad", Type = FoodTypeMOD.Salad });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 8, Name = "Nuggets", Type = FoodTypeMOD.Fries });
                context.SaveChanges();
            }

            using (var context = new TodoContextBLL(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> desert = foodRequests.GetDesertsBLL();

                Assert.Equal(2, desert.Count());
            }

        }

        [Fact]
        public void GetSalads_Returns_Only_Salads()
        {
            var options = new DbContextOptionsBuilder<TodoContextBLL>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Salads")
           .Options;

            using (var context = new TodoContextBLL(options))
            {
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 1, Name = "French Fries", Type = FoodTypeMOD.Fries });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 2, Name = "Pudim", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 3, Name = "Coke", Type = FoodTypeMOD.Drink });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 4, Name = "Ice Cream", Type = FoodTypeMOD.Desert });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 5, Name = "Meat", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 6, Name = "Bacon", Type = FoodTypeMOD.Grill });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 7, Name = "Caesar Salad", Type = FoodTypeMOD.Salad });
                context.FoodRequestToDo.Add(new FoodRequestItemMOD { Id = 8, Name = "Nuggets", Type = FoodTypeMOD.Fries });
                context.SaveChanges();
            }

            
            using (var context = new TodoContextBLL(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> salads = foodRequests.GetSaladsBLL();

                Assert.Equal(1, salads.Count());
            }

        }

    }
}
