using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class ItemViewModel
{
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    public IFormFile? ImageFile { get; set; }
}
