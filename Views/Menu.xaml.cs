using CoffeShopApp.ViewModel;

namespace CoffeShopApp.Views;

public partial class Menu : ContentPage
{
	MenuViewModel menuViewModel;
	public Menu(MenuViewModel viewModel)
	{
		InitializeComponent();
        menuViewModel = viewModel;
		BindingContext = menuViewModel;
	}
}