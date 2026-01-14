using MudBlazor;

namespace RealEstate.Dashboard.Models
{
	public class Announcement
	{
		public string Title { get; set; } = "";
		public string Description { get; set; } = "";
		public Severity Severity { get; set; }
		public string Icon { get; set; } = Icons.Material.Filled.Info;
	}
}
