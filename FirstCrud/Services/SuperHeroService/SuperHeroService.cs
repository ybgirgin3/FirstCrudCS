using FirstCrud.Models;

namespace FirstCrud.Services.SuperHeroService;

public class SuperHeroService: ISuperHeroService
{
    // define objects static for dev purpose
    private static readonly List<SuperHero> SuperHeroes = new()
    {
        // hard coded object
        new SuperHero()
        {
            Id = 1,
            Name = "Spider Man",
            FirstName = "Peter",
            LastName = "Parker",
            Place = "New York City"
        },
        
        // hard coded object
        new SuperHero()
        {
            Id = 2,
            Name = "Batman",
            FirstName = "Bekocan",
            LastName = "Girgin",
            Place = "Adapazari City"
        }
    };

    public List<SuperHero> GetAllHeroes()
    {
        return SuperHeroes;
    }

    public SuperHero GetSingleHero(int id)
    {
        var hero = SuperHeroes.Find(x => x.Id == id);
        if (hero is null)
        {
            return null;
        }
        return hero;
    }

    public List<SuperHero> AddHero(SuperHero hero)
    {
        SuperHeroes.Add(hero);
        return SuperHeroes;
    }

    public List<SuperHero> UpdateHero(int id, SuperHero request)
    {
        // throw new NotImplementedException();
        var hero = SuperHeroes.Find(x => x.Id == id);
        if (hero is null)
        {
            return null;
        }

        // define new values to current object with "id"
        hero.FirstName = request.FirstName;
        hero.LastName = request.LastName;
        hero.Name = request.Name;
        hero.Place = request.Place;

        return SuperHeroes;

    }

    public List<SuperHero> DeleteHero(int id)
    {
        // throw new NotImplementedException();
        var hero = SuperHeroes.Find(x => x.Id == id);
        if (hero is null)
        {
            return null;
        }
        
        SuperHeroes.Remove(hero);
        return SuperHeroes;
    }
}