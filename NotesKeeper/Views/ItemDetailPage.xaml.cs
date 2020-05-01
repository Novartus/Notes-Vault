using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NotesKeeper.Models;
using NotesKeeper.ViewModels;

namespace NotesKeeper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public void Cancel_Clicked(object Sender, EventArgs eventArgs)
        {
            DisplayAlert("Cancel Option", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(object Sender, EventArgs eventArgs)
        {
            DisplayAlert("Save Option", "Save was selected", "Button 2", "Button 1");
        }
    }
}