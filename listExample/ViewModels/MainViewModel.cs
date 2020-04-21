using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using listExample.Models;
using Xamarin.Forms;

namespace listExample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Item> product;
        public ObservableCollection<Item> Product
        {
            get { return product; }
            set { SetProperty(ref product, value); }
        }

        public ICommand DeleteProductCommand { get; set; }

        public MainViewModel()
        {
            Title = "Products";
            GetPrducts();

            DeleteProductCommand = new Command<Item>(ExecuteDeleteProductCommand);

        }

        void ExecuteDeleteProductCommand(Item item)
        {
            Product.Remove(item);
        }

        public void GetPrducts()
        {
            Product = new ObservableCollection<Item>()
            {
                new Item()
                {
                    Id = "1",
                    Name = "Prdouct 1",
                    Description = "Test Description 1"
                },
                new Item()
                {
                    Id = "2",
                    Name = "Prdouct 2",
                    Description = "Test Description 2"
                },
                new Item()
                {
                    Id = "3",
                    Name = "Prdouct 3",
                    Description = "Test Description 3"
                },
                new Item()
                {
                    Id = "4",
                    Name = "Prdouct 4",
                    Description = "Test Description 4"
                },
                new Item()
                {
                    Id = "5",
                    Name = "Prdouct 5",
                    Description = "Test Description 5"
                },
                new Item()
                {
                    Id = "6",
                    Name = "Prdouct 6",
                    Description = "Test Description 6"
                },
                new Item()
                {
                    Id = "7",
                    Name = "Prdouct 7",
                    Description = "Test Description 7"
                },
                new Item()
                {
                    Id = "8",
                    Name = "Prdouct 8",
                    Description = "Test Description 8"
                }
            };
        }
    }
}
