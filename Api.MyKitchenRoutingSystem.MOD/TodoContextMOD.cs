using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.MOD
{
    public class TodoContextMOD : DbContext
    {
        public TodoContextMOD(DbContextOptions<TodoContextMOD> options)
            : base(options)
        {
        }

        public DbSet<FoodRequestItemMOD> FoodRequestToDo { get; set; }
    }
}
