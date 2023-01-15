using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeShopApp.Models;

namespace CoffeShopApp.ViewModel
{
    public class MenuViewModel
    { 
        public ObservableCollection<Beverages> Beverages { get; set; }
        public MenuViewModel(INavigation navigation)
        {
            Beverages = new ObservableCollection<Beverages>
            {
                new Beverages
                {
                    Picture = "espresso.png",
                    Name = "Espresso",
                    Price = "2"
                },
                new Beverages
                {
                    Picture = "chailatte.png",
                    Name = "Chai Latte",
                    Price = "3"

                },
                new Beverages
                {
                    Picture = "tea.png",
                    Name = "Hand Brewed Tea",
                    Price = "2.5"

                },
                new Beverages
                {
                    Picture = "macchiato.png",
                    Name = "Iced Carmel Macchiato",
                    Price = "3.25"

                },
                new Beverages
                {
                    Picture = "shake.png",
                    Name = "Chocolate Shake",
                    Price = "3.5"
                }
            };
<<<<<<< Updated upstream
=======
<<<<<<< Updated upstream
=======
            CartItems = new ObservableCollection<Beverages> { };
            ItemClick = new Command<Beverages>(executeItemClick);
            
            CartClick = new Command(executeCartClick);
            // this.navigation = navigation;
        }
        private INavigation navigation =  App.Current.MainPage.Navigation;

        async void executeItemClick(Beverages item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new Details(this));
>>>>>>> Stashed changes
        }

        async void executeCartClick()
        {
            this.CartItems.Add(this.SelectedItem);
>>>>>>> Stashed changes
        }
    }
}
