public class AuthState
{
	public bool IsAuthenticated { get; private set; }

	public void Login()
	{
		IsAuthenticated = true;
	}

	public void Logout()
	{
		IsAuthenticated = false;
	}
}
