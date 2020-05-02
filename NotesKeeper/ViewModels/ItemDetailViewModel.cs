using System;

using NotesKeeper.Models;

namespace NotesKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        //public Item Item { get; set; }
        public Note Note { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Note = new Note { Heading = "Test Note", Text="Text for note in viewmodel"};
        }
    }
}
