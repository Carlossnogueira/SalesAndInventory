using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesAndInventory.Domain.Entities.Adress;

public class City
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public int StateId { get; set; }

    [ForeignKey("StateId")]
    public State State { get; set; } = null!;
    public ICollection<Adress> Adress = new List<Adress>();
}
