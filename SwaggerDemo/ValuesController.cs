using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace SwaggerDemo.Controllers
{
    [Route("SwaggerDemo/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Get Names
        /// </summary>
        /// 
        // Get Api/value 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        /// <summary>
        /// Get Name by Id
        /// </summary>
        //Get Api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            var value = await _context.Values.FindAsync();
            return Ok(value);
        }

        //Post api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        //Put Api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        //Delete Api/Values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}
