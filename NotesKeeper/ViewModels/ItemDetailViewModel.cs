using System;
using System.Collections.Generic;
using NotesKeeper.Models;

namespace NotesKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading
        {
            get { return Note.Heading; }
            set 
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }
        public ItemDetailViewModel(Item item = null)
        {
            InitializeCourseList();
            Note = new Note
            {
                Heading = "Test Note",
                Text = "Text for note in viewmodel",
                Course = CourseList[0]
            };

        }


        async void InitializeCourseList()
        {
            CourseList = await CourseDataStore.GetCoursesAsync();
        }
    }
}
