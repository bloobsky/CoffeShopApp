using CoffeShopApp.ViewModel;
namespace CoffeShopApp.Views;

public partial class Details : ContentPage
{
	public Details(MenuViewModel item)
	{
		InitializeComponent();
		BindingContext = item;
	}
}