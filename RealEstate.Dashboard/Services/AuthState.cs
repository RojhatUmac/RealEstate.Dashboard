public class AuthState
{
	public bool IsLoggedIn { get; private set; }

	public event Action? OnChange;

	public void Login()
	{
		IsLoggedIn = true;
		OnChange?.Invoke();
	}

	public void Logout()
	{
		IsLoggedIn = false;
		OnChange?.Invoke();
	}
}