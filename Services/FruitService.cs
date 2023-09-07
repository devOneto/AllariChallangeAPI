using AllariChallangeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllariChallangeAPI.Services;

public interface IFruitService 
{
    public Task<IList<Fruit>> GetAll();
}

public class FruitService : IFruitService
{
    private IFruitRepository _repository;
    public FruitService( IFruitRepository repository)
    {
        _repository = repository;
    }

    public async Task<IList<Fruit>> GetAll() => await _repository.GetAll();
}