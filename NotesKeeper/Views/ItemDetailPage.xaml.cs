using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NotesKeeper.Models;
using NotesKeeper.ViewModels;
using System.Collections.Generic;
using NotesKeeper.Services;

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

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }

        // Cancel knap
        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PopModalAsync();

        }

        // Save knap
        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            // Determine appropriate message
            var message = viewModel.IsNewNote ? "SaveNote" : "UpdateNote";

            // Send appropriate message, include the affected note
            MessagingCenter.Send(this, message, viewModel.Note);

            Navigation.PopModalAsync();
        }

    }
}