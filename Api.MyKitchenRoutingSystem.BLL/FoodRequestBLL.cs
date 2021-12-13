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
        private readonly TodoContextMOD _context;
        public FoodRequestBLL(TodoContextMOD context)
        {
            _context = context;
        }

        public static FoodRequestToDoDTOMOD FoodRequestItemToDoDTOBLL(FoodRequestItemMOD foodRequestItem) =>
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

        public IQueryable<FoodRequestToDoDTOMOD> GetAllFoodRequestsToDoBLL()
        {
            return _context.FoodRequestToDo.Select(x => FoodRequestItemToDoDTOBLL(x));
        }

        public FoodRequestItemMOD GetFoodRequestToDoBLL(long id)
        {
            return  _context.FoodRequestToDo.Find(id);
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
