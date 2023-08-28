using FirstCrud.Models;
using FirstCrud.Services.SuperHeroService;
using Microsoft.AspNetCore.Mvc;

namespace FirstCrud.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroController : ControllerBase
{
    private readonly ISuperHeroService _superHeroService;

    public SuperHeroController(ISuperHeroService superHeroService)
    {
        _superHeroService = superHeroService;
    }

    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
    {
        var results = _superHeroService.GetAllHeroes();
        return Ok(results);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
    {
        var singleHero = _superHeroService.GetSingleHero(id);
        return Ok(singleHero);
    }

    [HttpPost]
    public async Task<ActionResult<List<SuperHero>>> AddHero([FromBody] SuperHero hero)
    {
        var newHeroes = _superHeroService.AddHero(hero);
        return Ok(newHeroes);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
    {
        var newHero = _superHeroService.UpdateHero(id, request);
        return Ok(newHero);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
    {
        // delete and return new all heroes
        var results = _superHeroService.DeleteHero(id);
        return Ok(results);
    }
}
