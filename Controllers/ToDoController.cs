using dockerapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class ToDoController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ToDoController(ApiDbContext context)
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
        /// GET/ToDo
        /// </remarks> 
        [HttpGet]
        public object Get()
        {
            return _context.ToDos.Where(b => b.Title.Contains("Title")).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Priority = c.Priority
            }).ToList();
        }

        /// <summary>
        /// This method shows all todos by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/ToDo/title1
        /// </remarks>
        [HttpGet("{title}")]
        public object GetByTitle(string title)
        {
            return _context.ToDos.Where(b => b.Title == title).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Priority = c.Priority
            }).ToList();
        }

    }
}