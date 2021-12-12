using Api.MyKitchenRoutingSystem.MOD;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.BLL
{
    public class FoodRequestBLL
    {
        private readonly TodoContextBLL _context;
        public FoodRequestBLL(TodoContextBLL context)
        {
            _context = context;
        }

        private static FoodRequestToDoDTOMOD FoodRequestItemToDoDTO(FoodRequestItemMOD foodRequestItem) =>
        new FoodRequestToDoDTOMOD
        {
            Id = foodRequestItem.Id,
            Name = foodRequestItem.Name,
            Type = foodRequestItem.Type
        };

        public IQueryable<FoodRequestItemMOD> GetFriesBLL()
        {

            return  (from requestedFood in _context.FoodRequestToDo where requestedFood.Type == FoodTypeMOD.Fries select requestedFood);
        }

        public IQueryable<FoodRequestItemMOD> GetGrillsBLL()
        {
            
            return (from requestedFood in _context.FoodRequestToDo where requestedFood.Type == FoodTypeMOD.Grill select requestedFood);
        }

        public IQueryable<FoodRequestItemMOD> GetSaladsBLL()
        {

            return (from requestedFood in _context.FoodRequestToDo where requestedFood.Type == FoodTypeMOD.Salad select requestedFood);
        }

        public IQueryable<FoodRequestItemMOD> GetDrinksBLL()
        {

            return (from requestedFood in _context.FoodRequestToDo where requestedFood.Type == FoodTypeMOD.Drink select requestedFood);
        }

        public IQueryable<FoodRequestItemMOD> GetDesertsBLL()
        {

            return from requestedFood in _context.FoodRequestToDo where requestedFood.Type == FoodTypeMOD.Desert select requestedFood;
        }

        public async Task<List<FoodRequestToDoDTOMOD>> GetAllFoodRequestsToDoBLL()
        {
            return _context.FoodRequestToDo.Select(x => FoodRequestItemToDoDTO(x)).ToList();
        }

        public async Task<ActionResult<FoodRequestItemMOD>> GetFoodRequestToDoBLL(long id)
        {
            return await _context.FoodRequestToDo.FindAsync(id);
        }

        public async Task<int> PostFoodRequestBLL(FoodRequestItemMOD foodRequest)
        {
            _context.FoodRequestToDo.Add(foodRequest);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteFoodRequestToDoBLL(long id)
        {
            var todoItem = await _context.FoodRequestToDo.FindAsync(id);

            _context.FoodRequestToDo.Remove(todoItem);
            return await _context.SaveChangesAsync();
        }
    }
}
