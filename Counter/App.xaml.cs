using Counter.Views;

namespace Counter;

public partial class App : Application
{
	public App(MainView page)
	{
		InitializeComponent();

		MainPage = page;
    }
}
