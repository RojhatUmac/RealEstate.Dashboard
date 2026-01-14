using RealEstate.Dashboard.Models;

namespace RealEstate.Dashboard.Data;

public static class HouseStore
{
	public static List<House> Houses { get; set; } =
		FakeHouseData.GetHouses();
}
