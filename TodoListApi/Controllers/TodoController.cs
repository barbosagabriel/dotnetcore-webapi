using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;

namespace TodoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        //private readonly TodoContext _context;
        private ILoggerManager _logger;
        private IToDoItemRepository _toDoItemRepository;

        public TodoController(//TodoContext context, 
            ILoggerManager logger, IToDoItemRepository toDoItemRepository)
        {
            //_context = context;
            _logger = logger;
            _toDoItemRepository = toDoItemRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var toDoItems = _toDoItemRepository.FindAll();
                _logger.LogInfo("Returned all ToDo Items from database.");
                return Ok(toDoItems);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside ToDo#GetAll action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }

            
            //return _context.TodoItems.ToList();
        }

        //[HttpGet("{id}", Name = "GetTodo")]
        //public ActionResult<TodoItem> GetById(long id)
        //{
        //    _logger.LogInfo($"[GET] GetById called with id = {id}.");

        //    var item = _context.TodoItems.Find(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    return item;
        //}

        //[HttpPost]
        //public IActionResult Create(TodoItem item)
        //{
        //    _logger.LogInfo("[POST] Create called.");

        //    _context.TodoItems.Add(item);
        //    _context.SaveChanges();

        //    return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update(long id, TodoItem item)
        //{
        //    _logger.LogInfo($"[PUT] Update called with id = {id}.");

        //    var todo = _context.TodoItems.Find(id);
        //    if (todo == null)
        //    {
        //        return NotFound();
        //    }

        //    todo.IsComplete = item.IsComplete;
        //    todo.Name = item.Name;

        //    _context.TodoItems.Update(todo);
        //    _context.SaveChanges();
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(long id)
        //{
        //    _logger.LogInfo($"[DELETE] Delete called with id = {id}.");

        //    var todo = _context.TodoItems.Find(id);
        //    if (todo == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TodoItems.Remove(todo);
        //    _context.SaveChanges();
        //    return NoContent();
        //}
    }
}
