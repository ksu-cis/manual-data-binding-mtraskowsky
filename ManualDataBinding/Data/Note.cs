using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        public event EventHandler NoteChanged;

        private string title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (title == value) return; // if the new title is the same as the current value, we don't need to update it
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body { get; set; } = "";
    }
}
