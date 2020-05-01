using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NotesKeeper.Models;

namespace NotesKeeper.Services
{
    public interface ICourseDataStore
    {
        Task<String> AddNoteAsync(Note courseNote);
        Task<bool> UpdateNoteAsync(Note courseNote);
        Task<Note> GetNoteAsync(String id);
        Task<IList<Note>> GetNotesAsync();
        Task<IList<String>> GetCoursesAsync(); 
    }
}
