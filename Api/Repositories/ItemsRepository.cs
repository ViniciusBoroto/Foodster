//using Api.Contexts;
//using Api.Models;

//namespace Api.Repositories;

//public class ItemsRepository : IItemsRepository
//{
//    private readonly AppDbContext _context;

//    public ItemsRepository(AppDbContext context)
//    {
//        _context = context;
//    }

//    public Item Create(Item item)
//    {
//        _context.Items.Add(item);
//        _context.SaveChanges();
//        return item;
//    }

//    public Item Delete(int id)
//    {
//        var item = _context.Items.FirstOrDefault(x => x.Id == id);
//        if (item != null)
//            throw new ArgumentNullException() 

//        _context.Items.Remove(item);
//        _context.SaveChanges();
//        return item;
//    }

//    public Item Get(int id)
//    {
//        return _context.Items.Find(id);
//    }

//    public IEnumerable<Item> GetItems()
//    {
//        return _context.Items.ToList();
//    }

//    public Item Update(Item item)
//    {
//        _context.Entry(item).State =
//}
//}
