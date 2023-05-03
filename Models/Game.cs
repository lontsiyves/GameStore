namespace GameStore.Client.Models;
using System.ComponentModel.DataAnnotations;

public class Game
  {
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required]
    [StringLength(20)]
    public required string Genre { get; set; }

    [Required]
    [Range(1,10000)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

  }
