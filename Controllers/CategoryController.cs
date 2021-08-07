using Microsoft.AspNetCore.Mvc;
using Backoffice.Models;

[Route("categories")]
public class CategoryController : ControllerBase
{
    // https://localhost:5001/categories

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return "GET";
    }

    [HttpPost]
    [Route("")]
    public Category Post([FromBody] Category model)
    {
        return model;
    }

    [HttpPut]
    [Route("{id:int}")]
    public Category Put(int id, [FromBody] Category model)
    {
        if (model.Id == id)
            return model;

        return null;

    }

    [HttpDelete]
    [Route("{id:int}")]
    public string Delete()
    {
        return "DELETE";
    }

}