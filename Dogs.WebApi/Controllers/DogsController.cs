using Dogs.WebApi.Data;
using Dogs.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dogs.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        // GET: api/<DogsController>
        [HttpGet]
        public IEnumerable<DogShortInfo> Get()
        {
            return DataSeeds.DogsList.Select(d => new DogShortInfo()
            {
                Id = d.Id,
                Name = d.Name,
                ImgUrl = d.ImgUrl,
                Family = d.Family?.Name ?? "Не задано"
            });
        }

        // GET api/<DogsController>/5
        [HttpGet("{id}")]
        public Dog Get(Guid id)
        {
            return DataSeeds.DogsList.FirstOrDefault(x => x.Id == id);
        }

        // // POST api/<DogsController>
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }
        //
        // // PUT api/<DogsController>/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }
        //
        // // DELETE api/<DogsController>/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}