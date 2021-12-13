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
        public void GetFriesReturnsOnlyFries()
        {
            var options = new DbContextOptionsBuilder<TodoContextMOD>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo")
           .Options;

            using (var context = new TodoContextMOD(options))
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

            using (var context = new TodoContextMOD(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> fries = foodRequests.GetFriesBLL();

                Assert.Equal(2, fries.Count());
            }

        }

        [Fact]
        public void GetGrillsReturnsOnlyGrills()
        {
            var options = new DbContextOptionsBuilder<TodoContextMOD>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Grills")
           .Options;

            using (var context = new TodoContextMOD(options))
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

            using (var context = new TodoContextMOD(options))
            {

                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> grills = foodRequests.GetGrillsBLL();

                Assert.Equal(2, grills.Count());
            }
        }

        [Fact]
        public void GetDrinksReturnsOnlyDrinks()
        {
            var options = new DbContextOptionsBuilder<TodoContextMOD>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Drinks")
           .Options;

            using (var context = new TodoContextMOD(options))
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


            using (var context = new TodoContextMOD(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> drinks = foodRequests.GetDrinksBLL();

                Assert.Equal(1, drinks.Count());
            }
        }

        [Fact]
        public void GetDesertsReturnsOnlyDeserts()
        {
            var options = new DbContextOptionsBuilder<TodoContextMOD>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Deserts")
           .Options;

            using (var context = new TodoContextMOD(options))
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

            using (var context = new TodoContextMOD(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> desert = foodRequests.GetDesertsBLL();

                Assert.Equal(2, desert.Count());
            }

        }

        [Fact]
        public void GetSaladsReturnsOnlySalads()
        {
            var options = new DbContextOptionsBuilder<TodoContextMOD>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-Salads")
           .Options;

            using (var context = new TodoContextMOD(options))
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


            using (var context = new TodoContextMOD(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestItemMOD> salads = foodRequests.GetSaladsBLL();

                Assert.Equal(1, salads.Count());
            }

        }

        [Fact]
        public void CheckingIfGetAllRequestsReturnsAllRequests()
        {
            var options = new DbContextOptionsBuilder<TodoContextMOD>()
           .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-GetAll")
           .Options;

            using (var context = new TodoContextMOD(options))
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


            using (var context = new TodoContextMOD(options))
            {
                FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                IQueryable<FoodRequestToDoDTOMOD> requests = foodRequests.GetAllFoodRequestsToDoBLL();


                Assert.Equal(8, requests.Count());
            }

        }

        [Fact]
        public void CheckingIfGetByIdReturnTheCorrectRequest()
        {
            
            {
                var options = new DbContextOptionsBuilder<TodoContextMOD>()
               .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-CheckingIF")
               .Options;

                using (var context = new TodoContextMOD(options))
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


                using (var context = new TodoContextMOD(options))
                {
                    FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                    FoodRequestItemMOD foodRequested = foodRequests.GetFoodRequestToDoBLL(5);


                    Assert.Equal(context.FoodRequestToDo.First(x => x.Id == 5), foodRequested);
                }

            }
        }

        [Fact]
        public void CheckingIfAddingARequestWorks()
        {

            {
                var options = new DbContextOptionsBuilder<TodoContextMOD>()
               .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-CheckingIfAdding")
               .Options;

                using (var context = new TodoContextMOD(options))
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


                using (var context = new TodoContextMOD(options))
                {
                    FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                    FoodRequestItemMOD foodRequestToBeAdd = new FoodRequestItemMOD { Id = 9, Name = "Fish", Type = FoodTypeMOD.Grill };
                    Task<int> foodRequested = foodRequests.PostFoodRequestBLL(foodRequestToBeAdd);


                    Assert.Equal(TaskStatus.RanToCompletion, foodRequested.Status);
                }

            }
        }

        [Fact]
        public void CheckingIfDeleteByIdWorks()
        {

            {
                var options = new DbContextOptionsBuilder<TodoContextMOD>()
               .UseInMemoryDatabase(databaseName: "FoodRequestsToDo-CheckingIfDeleteByIdWorks")
               .Options;

                using (var context = new TodoContextMOD(options))
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


                using (var context = new TodoContextMOD(options))
                {
                    FoodRequestBLL foodRequests = new FoodRequestBLL(context);
                    Task<int> foodRequestDeleted = foodRequests.DeleteFoodRequestToDoBLL(5);

                    Assert.Equal(TaskStatus.RanToCompletion, foodRequestDeleted.Status);
                }

            }
        }
    }
}

