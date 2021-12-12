using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.Models
{
    public class FoodRequestToDoDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public FoodType Type { get; set; }

    }
}
