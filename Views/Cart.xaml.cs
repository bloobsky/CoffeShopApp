using CoffeShopApp.Models;
using CoffeShopApp.ViewModel;

namespace CoffeShopApp.Views;

public partial class Cart : ContentPage
{
	MenuViewModel menuViewModel;

    public Cart()
	{
		InitializeComponent();
        menuViewModel = new MenuViewModel(Navigation);
        BindingContext = menuViewModel;
	}
}