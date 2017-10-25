using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShowAndTellBlazor.API.Models;

namespace ShowAndTellBlazor.API.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return new[] {
                new TodoItem
                {
                    Text = "Wash the dishes."
                },
                new TodoItem
                {
                    Text = "Drive home."
                }
            };
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
