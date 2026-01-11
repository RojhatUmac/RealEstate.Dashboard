using RealEstate.Dashboard.Models;

namespace RealEstate.Dashboard.Data;

public static class FakeHouseData
{
	public static List<House> GetHouses()
	{
		return new List<House>
		{
			new House
            {
	            Id = 1,
	            Title = "Deniz Manzaralı Ev",
	            City = "İstanbul",
	            Price = 2500000,
	            Description = "Denize sıfır, geniş balkonlu ve modern tasarımlı bir ev.",
				ImageUrl = "https://picsum.photos/900/450"
			}
,
			new House
			{
				Id = 2,
				Title = "Merkez Daire",
				City = "Ankara",
				Price = 2500000,
				Description = "Denize sıfır, geniş balkonlu ve modern tasarımlı bir ev.",
				ImageUrl = "https://picsum.photos/900/450"
			}
		};
	}
}
