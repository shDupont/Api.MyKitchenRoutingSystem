using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.MOD
{
    public class TodoContextBLL : DbContext
    {
        public TodoContextBLL(DbContextOptions<TodoContextBLL> options)
            : base(options)
        {
        }

        public DbSet<FoodRequestItemMOD> FoodRequestToDo { get; set; }
    }
}
