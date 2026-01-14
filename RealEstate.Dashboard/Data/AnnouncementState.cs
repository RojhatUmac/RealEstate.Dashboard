using RealEstate.Dashboard.Models;
using MudBlazor;

namespace RealEstate.Dashboard.Data
{
	public class AnnouncementState
	{
		private readonly HouseState _houseState;

		public AnnouncementState(HouseState houseState)
		{
			_houseState = houseState;
		}

		public List<Announcement> GetAnnouncements()
		{
			var list = new List<Announcement>();
			var houses = _houseState.Houses;

			if (!houses.Any())
			{
				list.Add(new Announcement
				{
					Title = "Hoş geldin 👋",
					Description = "Henüz hiç ilan eklemedin. İlk ilanını ekleyerek başlayabilirsin.",
					Severity = Severity.Info,
					Icon = Icons.Material.Filled.Info
				});

				return list;
			}

			var passiveCount = houses.Count(x => !x.IsActive);
			if (passiveCount > 0)
			{
				list.Add(new Announcement
				{
					Title = "Pasif ilanlar var",
					Description = $"{passiveCount} ilan pasif durumda.",
					Severity = Severity.Warning,
					Icon = Icons.Material.Filled.PauseCircle
				});
			}

			var noImageCount = houses.Count(x => x.Images == null || !x.Images.Any());
			if (noImageCount > 0)
			{
				list.Add(new Announcement
				{
					Title = "Eksik görseller",
					Description = $"{noImageCount} ilanın görseli yok.",
					Severity = Severity.Error,
					Icon = Icons.Material.Filled.ImageNotSupported
				});
			}

			return list;
		}
	}
}
