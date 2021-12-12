using System;

namespace Api.MyKitchenRoutingSystem.MOD
{
    public class FoodRequestItemMOD
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public FoodTypeMOD Type { get; set; }
    }
}
