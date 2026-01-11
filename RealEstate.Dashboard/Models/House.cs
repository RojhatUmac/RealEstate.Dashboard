namespace RealEstate.Dashboard.Models;

public class House
{
	public int Id { get; set; }
	public string Title { get; set; } = "";
	public string City { get; set; } = "";
	public decimal Price { get; set; }
	public string Description { get; set; } = "";
	public string ImageUrl { get; set; } = "";
}
