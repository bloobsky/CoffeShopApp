using CoffeShopApp.ViewModel;

namespace CoffeShopApp.Views;

public partial class Cart : ContentPage
{

	public Cart(MenuViewModel menuViewModel)
	{
		InitializeComponent();
		BindingContext = menuViewModel;
	}
}