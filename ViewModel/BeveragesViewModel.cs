using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeShopApp.Models;


namespace CoffeShopApp.ViewModel
{
    public class BeveragesViewModel
    {
        public ObservableCollection<Beverages> Beverages { get; set; }
        public BeveragesViewModel() 
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
                },
            };
        }
    }
}
