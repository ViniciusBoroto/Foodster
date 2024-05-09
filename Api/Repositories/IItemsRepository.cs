using Api.Models;

namespace Api.Repositories;

public interface IItemsRepository
{
    public IEnumerable<Item> GetItems();
    public Item Get(int id);
    public Item Create(Item item);
    public Item Update(Item item);
    public Item Delete(int id);
}