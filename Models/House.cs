

namespace greglist_sql.Models;

    public class House
{
    public int Id { get; set; }
    public int? Bathrooms { get; set; }
    public int? Bedrooms { get; set; }
    public double? Price { get; set; }
    public int? Levels { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
