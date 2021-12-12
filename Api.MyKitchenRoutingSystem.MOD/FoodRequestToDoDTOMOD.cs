using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.MOD
{
    public class FoodRequestToDoDTOMOD
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public FoodTypeMOD Type { get; set; }

    }
}
