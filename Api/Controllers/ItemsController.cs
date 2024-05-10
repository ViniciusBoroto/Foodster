using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly IItemsRepository _repository;

    public ItemsController(IItemsRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _repository.GetItems();
        return Ok(items);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var item = _repository.Get(id);
        return Ok(item);
    }
    [HttpPost]
    public IActionResult Post(Item item)
    {
        _repository.Create(item);
        return Ok(item);
    }
    [HttpPut]
    public IActionResult Put(Item item)
    {
        _repository.Update(item);
        return Ok(item);
    }
}
