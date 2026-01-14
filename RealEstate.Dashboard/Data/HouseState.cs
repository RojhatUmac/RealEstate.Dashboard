using RealEstate.Dashboard.Models;

public class HouseState
{
	public List<House> Houses { get; set; } = new();

	public event Action? OnChange;

	public void NotifyStateChanged()
	{
		OnChange?.Invoke();
	}
}
