using dockerapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
using System;

namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class TodoController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context)
        {
            _context = context;
        }
#pragma warning restore CS1591

        /// <summary>
        /// This method shows all todos
        /// </summary>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Todo
        /// </remarks> 
        [HttpGet]
        public object Get()
        {
            return _context.Todos.Select(c => new
            {
                Id = c.Id,
                Title = c.Title,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Priority = c.Priority
            }).ToList();
        }

        /// <summary>
        /// This method shows a todo item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Todo/id
        /// </remarks>
        [HttpGet("{id}")]
        public object GetById(int id)
        {
            return _context.Todos.Where(b => b.Id == id).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Priority = c.Priority
            }).ToList();
        }

        /// <summary>
        /// This method adds a new todo item
        /// </summary>
        /// Sample request
        /// POST/todo/
        /// </remarks>
        [HttpPost]
        public void Post([FromBody]Todo item)
        {
            _context.Add(item);
            _context.SaveChanges();            
        }

    }
}