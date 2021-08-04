using Microsoft.AspNetCore.Mvc;

// https://localhost:5001/categories

// Endpoint => URL
// http://localhost:5000
// https://localhost:5001/categories
// Produção sempre usar https

[Route("categories")]
public class CategoryController : ControllerBase
{
    // https://localhost:5001/banana/madura
    // [Route("madura")]
    // ou
    // https://localhost:5001/banana/
    // [Route("")]


    // https://localhost:5001/categories
    [Route("")]
    public string MeuMetodo()
    {
        return "Olá mundo!";
    }

}