using CoffeShopApp.ViewModel;
namespace CoffeShopApp.Views;

public partial class Details : ContentPage
{
	MenuViewModel menuViewModel;

    public Details(MenuViewModel item)
	{
		InitializeComponent();
		menuViewModel= item;
		BindingContext = menuViewModel;
	}
}