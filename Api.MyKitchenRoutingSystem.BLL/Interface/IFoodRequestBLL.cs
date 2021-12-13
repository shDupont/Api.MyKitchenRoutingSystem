using Api.MyKitchenRoutingSystem.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.BLL.Interface
{
    public interface IFoodRequestBLL
    {
        Task<int> DeleteFoodRequestToDoBLL(long id);
        Task<int> PostFoodRequestBLL(FoodRequestItemMOD foodRequest);
        FoodRequestItemMOD GetFoodRequestToDoBLL(long id);
        IQueryable<FoodRequestToDoDTOMOD> GetAllFoodRequestsToDoBLL();
        IQueryable<FoodRequestItemMOD> GetDesertsBLL();
        IQueryable<FoodRequestItemMOD> GetDrinksBLL();
        IQueryable<FoodRequestItemMOD> GetSaladsBLL();
        IQueryable<FoodRequestItemMOD> GetGrillsBLL();

        IQueryable<FoodRequestItemMOD> GetFriesBLL();

    }
}
