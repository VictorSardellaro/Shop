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
    [Route("")]
    public string Put()
    {
        return "PUT";
    }

    [HttpDelete]
    [Route("")]
    public string Delete()
    {
        return "DELETE";
    }

}