using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.MyKitchenRoutingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Http;
using Api.MyKitchenRoutingSystem.BLL;
using Api.MyKitchenRoutingSystem.MOD;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.MyKitchenRoutingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodRequestController : ControllerBase 
    {
        private readonly TodoContext _context;
        private readonly FoodRequestBLL _foodRequestBLL;

        public FoodRequestController(TodoContext context)
        {
            _context = context;
        }

        public FoodRequestController(FoodRequestBLL foodRequestBLL) => _foodRequestBLL = foodRequestBLL;

        [HttpGet("/GetFries")]
        public async Task<IActionResult> GetFries()
        {

            try
            {
                if (_context.FoodRequestToDo.Count() == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return StatusCode(StatusCodes.Status200OK, _foodRequestBLL.GetFriesBLL() );
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet("/GetGrills")]
        public async Task<IActionResult> GetGrill()
        {
            try
            {
                if (_context.FoodRequestToDo.Count() == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return StatusCode(StatusCodes.Status200OK, _foodRequestBLL.GetGrillsBLL());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("/GetSalads")]
        public async Task<IActionResult> GetSalads()
        {
            try
            {
                if (_context.FoodRequestToDo.Count() == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return StatusCode(StatusCodes.Status200OK, _foodRequestBLL.GetSaladsBLL());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("/GetDrinks")]
        public async Task<IActionResult> GetDrinks()
        {
            try
            {
                if (_context.FoodRequestToDo.Count() == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return StatusCode(StatusCodes.Status200OK, _foodRequestBLL.GetDrinksBLL());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("/GetDeserts")]
        public async Task<IActionResult> GetDeserts() 
        {
            try
            {
                if (_context.FoodRequestToDo.Count() == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return StatusCode(StatusCodes.Status200OK, _foodRequestBLL.GetDesertsBLL());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFoodRequestsToDo()
        {
            try
            {
                if (_context.FoodRequestToDo.Count() == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }

                return StatusCode(StatusCodes.Status200OK, await _foodRequestBLL.GetAllFoodRequestsToDoBLL());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/FoodRequestToDo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodRequestItem>> GetFoodRequestToDo(long id)
        {
            var todoItem = await _foodRequestBLL.GetFoodRequestToDoBLL(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return StatusCode(StatusCodes.Status200OK, todoItem);
        }

        // POST api/FoodRequestToDo
        [HttpPost]
        public async Task<IActionResult> PostFoodRequest(FoodRequestItemMOD foodRequest)
        {
            try
            {
                var postFoodRequest =_foodRequestBLL.PostFoodRequestBLL(foodRequest);
                return CreatedAtAction(nameof(GetFoodRequestToDo), new { id = foodRequest.Id }, postFoodRequest);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status409Conflict);

            }
        }

        
        // DELETE api/FoodRequestToDo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodRequestToDo(long id)
        {
            var todoItem = await _context.FoodRequestToDo.FindAsync(id);
            if (todoItem == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            try
            {
                await _foodRequestBLL.DeleteFoodRequestToDoBLL(id);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status409Conflict);
            }
        }
    }
}