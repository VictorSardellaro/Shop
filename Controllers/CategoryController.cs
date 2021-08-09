using Microsoft.AspNetCore.Mvc;
using Backoffice.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

[Route("categories")]
public class CategoryController : ControllerBase
{
    // https://localhost:5001/categories

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Category>>> Get()
    {
        return new List<Category>();
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Category>> GetById()
    {
        return new Category();
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Post([FromBody] Category model)
    {
        return Ok(model);
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Category>>> Put(int id, [FromBody] Category model)
    {
        if (model.Id == id)
            return Ok(model);

        return NotFound();

    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Category>>> Delete()
    {
        return Ok();
    }

}