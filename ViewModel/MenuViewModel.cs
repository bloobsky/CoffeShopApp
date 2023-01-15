using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CoffeShopApp.Models;
using CoffeShopApp.Views;

namespace CoffeShopApp.ViewModel
{
    public class MenuViewModel
    { 
        public ObservableCollection<Beverages> Beverages { get; set; }
        public ObservableCollection<Beverages> CartItems { get; set; }

        public Beverages SelectedItem { get; set; }
        public ICommand ItemClick { get; set; }
        public ICommand CartClick { get; set; }
        public MenuViewModel()
        {
            Beverages = new ObservableCollection<Beverages>
            {
                new Beverages
                {
                    Picture = "espresso.png",
                    Quantity = "1",
                    Name = "Espresso",
                    Price = "2"
                },
                new Beverages
                {
                    Picture = "bagel.png",
                    Quantity = "1",
                    Name = "Bagel with organic cheese",
                    Price = "5.5"
                },
                new Beverages
                {
                    Picture = "chailatte.png",
                    Quantity = "1",
                    Name = "Chai Latte",
                    Price = "3"

                },
                new Beverages
                {
                    Picture = "burger.png",
                    Quantity = "1",
                    Name = "Organic beef burger",
                    Price = "11"
                },
                new Beverages
                {
                    Picture = "tea.png",
                    Quantity = "1",
                    Name = "Hand Brewed Tea",
                    Price = "2.5"

                },
                new Beverages
                {
                    Picture = "donut.png",
                    Quantity = "1",
                    Name = "Canadian Maple Donut",
                    Price = "3.75"
                },
                new Beverages
                {
                    Picture = "macchiato.png",
                    Quantity = "1",
                    Name = "Iced Carmel Macchiato",
                    Price = "3.25"

                },
                new Beverages
                {
                    Picture = "chicken.png",
                    Quantity = "1",
                    Name = "Organic Chicken Wrap",
                    Price = "8.25"
                },
                new Beverages
                {
                    Picture = "shake.png",
                    Quantity = "1",
                    Name = "Chocolate Shake",
                    Price = "3.5"
                }
            };
            CartItems = new ObservableCollection<Beverages> { };
            ItemClick = new Command<Beverages>(executeItemClick);
            
         //   CartClick = new Command<Beverages>(executeCartClick);
            this.navigation = navigation;
        }
        private INavigation navigation =  App.Current.MainPage.Navigation;

        async void executeItemClick(Beverages item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new Details(this));
        }
    }
}
