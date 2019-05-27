﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Context;
using Infra.Models;
using Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebApi_V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoRepository _todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            _todoRepository =  todoRepository;
        }

        // GET: api/Todo
        [HttpGet]
        public Task<IEnumerable<TodoItem>> GetTodoItems()
        {
            //return await _context.TodoItems.ToListAsync();
            return  _todoRepository.GetAllItems();
        }

        // GET: api/Todo/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        //{
        //    var todoItem = await _context.TodoItems.FindAsync(id);

        //    if (todoItem == null)
        //    {
        //        return NotFound();
        //    }

        //    return todoItem;
        //}

        //// POST: api/Todo
        //[HttpPost]
        //public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem item)
        //{
        //    _context.TodoItems.Add(item);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        //}

        //// PUT: api/Todo/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTodoItem(long id, TodoItem item)
        //{
        //    if (id != item.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(item).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //// DELETE: api/Todo/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTodoItem(long id)
        //{
        //    var todoItem = await _context.TodoItems.FindAsync(id);

        //    if (todoItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TodoItems.Remove(todoItem);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }
}