using CoffeShopApp.ViewModel;

namespace CoffeShopApp.Views;

public partial class Menu : ContentPage
{
	MenuViewModel menuViewModel;
	public Menu()
	{
		InitializeComponent();
		menuViewModel= new MenuViewModel(this.Navigation);
		BindingContext = menuViewModel;
	}
}