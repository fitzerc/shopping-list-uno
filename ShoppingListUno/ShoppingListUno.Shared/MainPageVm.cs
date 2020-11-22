using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListUno.Shared
{
    public class MainPageVm : BaseVm
    {
        private List<Item> _shoppingList = new List<Item>()
        {
            new Item() { Name = "Bread" },
            new Item() { Name = "Bananas" },
            new Item() { Name = "Eggs" },
            new Item() { Name = "Milk" },
        };
        public List<Item> ShoppingList
        {
            get
            {
                return _shoppingList;
            }
            set
            {
                OnPropertyChanged<string>(nameof(ShoppingList));
                _shoppingList = value;
            }
        }
    }

    public class Item
    {
        public string Name { get; set;}
    }
}
