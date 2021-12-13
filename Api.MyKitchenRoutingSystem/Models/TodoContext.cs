using Api.MyKitchenRoutingSystem.MOD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyKitchenRoutingSystem.Models
{
    public class TodoContext : TodoContextMOD
    {
        public TodoContext(DbContextOptions<TodoContextMOD> options)
            : base(options)
        {
        }

        public DbSet<FoodRequestItem> FoodRequestToDoMOD { get; set; }
    }
}
