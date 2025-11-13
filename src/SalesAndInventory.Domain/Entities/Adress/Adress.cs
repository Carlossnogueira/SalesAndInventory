using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesAndInventory.Domain.Entities.Adress;

public class Adress
{
    public long Id { get; set; }

    [Required]
    public string Street { get; set; } = string.Empty;

    [Required]
    public string Number { get; set; }

    public string Neighborhood { get; set; } = string.Empty;

    public int CityId { get; set; }
    [ForeignKey("CityId")]
    public City City { get; set; } = null!;
    
}
