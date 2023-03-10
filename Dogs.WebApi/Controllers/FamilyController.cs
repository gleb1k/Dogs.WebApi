using Dogs.WebApi.Data;
using Dogs.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dogs.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FamilyController : ControllerBase
{
    [HttpGet("get-all")]
    public IEnumerable<Family> GetAll()
    {
        return DataSeeds.FamilyList;
    }
}