namespace TUCanteen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new HomePage();
		MainPage = new LoginPage();
	}
}
