using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park 
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [StringLength(50)]
    public string Location { get; set; }
    public string Description { get; set; }
    [Required(ErrorMessage = "Must be a National Park or State Park.")]
    public string ParkType { get; set; }

  }
}