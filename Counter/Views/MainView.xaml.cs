using Counter.ViewModels;

namespace Counter.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}

