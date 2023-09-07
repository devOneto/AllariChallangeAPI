using AllariChallangeAPI.Models;
using AllariChallangeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllariChallangeAPI.Controllers;

[Controller]
[Route("[controller]")]
public class FruitController: ControllerBase
{
    private IFruitService _fruitService;
    public FruitController(IFruitService fruitService)
    {
        _fruitService = fruitService;
    }
    
    [HttpGet]
    public Task<IList<Fruit>> Get() => this._fruitService.GetAll();
}