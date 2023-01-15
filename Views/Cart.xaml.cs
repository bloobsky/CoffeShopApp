using CoffeShopApp.Models;
using CoffeShopApp.ViewModel;

namespace CoffeShopApp.Views;

public partial class Cart : ContentPage
{
	MenuViewModel menuViewModel;

    public Cart(MenuViewModel viewModel)
	{
		InitializeComponent();
        menuViewModel = viewModel;
        BindingContext = menuViewModel;
	}
}