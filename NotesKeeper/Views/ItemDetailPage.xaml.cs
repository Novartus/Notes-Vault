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
        //public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
            //BindingContext = Note;
            NoteCourse.BindingContext = this;
        }

        

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
            //BindingContext = Note;
            NoteCourse.BindingContext = this;
        }

        async void InitializeData()
        {
            var DataStore = new MockCourseDataStore();
            CourseList = await DataStore.GetCoursesAsync();
            //Note = new Note 
            //{
            //    Heading= "Test Note", 
            //    Text="Test Node Test",
            //    Course= CourseList[0]
            //};
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