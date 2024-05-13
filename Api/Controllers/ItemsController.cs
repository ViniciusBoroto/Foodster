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
    public IActionResult Create([FromForm]ItemViewModel itemView)
    {
        var filePath = Path.Combine("Storage", "Profile", itemView.ImageFile.FileName);

        using Stream fileStream = new FileStream(filePath, FileMode.Create);
        itemView.ImageFile.CopyTo(fileStream);

        var item = new Item(itemView.Name, itemView.Description, filePath);
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
