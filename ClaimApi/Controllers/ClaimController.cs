using ClaimApi.Model;
using ClaimApi.Model.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClaimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly AplicationDbContext contex;
                        
        public ClaimController(AplicationDbContext contex)
        {
            this.contex = contex;
        }
        // GET: api/<ClaimController>
        [HttpGet]
        public async Task<ActionResult<List<Claim>>> Get()
        {
            return await contex.Claims.ToListAsync();
        }

        // GET api/<ClaimController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClaimController>
        [HttpPost]
        public async Task<ActionResult> Post(Claim claim)
        {
            contex.Add(claim);
            await contex.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<ClaimController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClaimController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
