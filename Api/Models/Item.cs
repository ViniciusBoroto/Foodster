using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class Item
{
    public Item(string Name, string Description, string Image)
    {
        this.Name = Name;
        this.Description = Description;
        this.Image = Image;
    }

    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    public string? Image { get; set;}
}
