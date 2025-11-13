using System;
using System.ComponentModel.DataAnnotations;

namespace SalesAndInventory.Domain.Entities.Adress;

public class State
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = String.Empty;

    [Required, MaxLength(2)]
    public string Abbreviation { get; set; } = string.Empty;

    public ICollection<City> Cities { get; set; } = new List<City>();
}
