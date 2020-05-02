using System;
using System.Collections.Generic;
using NotesKeeper.Models;

namespace NotesKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        //public Item Item { get; set; }
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            InitializeCourseList();
            Note = new Note
            {
                Heading = "Test Note",
                Text = "Text for note in viewmodel",
                Course = CourseList[0]
            };

            //Title = item?.Text;
            //Note = new Note { Heading = "Test Note", Text="Text for note in viewmodel"};
        }


        async void InitializeCourseList()
        {
            CourseList = await CourseDataStore.GetCoursesAsync();
        }
    }
}
