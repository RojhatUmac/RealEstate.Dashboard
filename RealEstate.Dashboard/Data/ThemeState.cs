using MudBlazor;

namespace RealEstate.Dashboard.Data
{
	public class ThemeState
	{
		public bool IsDarkMode { get; private set; } = false;
		public Color PrimaryColor { get; private set; } = Color.Primary;

		public event Action? OnChange;

		public void ToggleDarkMode()
		{
			IsDarkMode = !IsDarkMode;
			Notify();
		}

		public void SetPrimaryColor(Color color)
		{
			PrimaryColor = color;
			Notify();
		}

		void Notify() => OnChange?.Invoke();
	}
}