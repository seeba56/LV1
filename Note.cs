using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Note
    {
        public String noteText;
        public int importance;
        public String author;

        public Note()
        {
            this.noteText = "Empty note";
            this.importance = 0;
            this.author = "Anonymous";
        }
        public Note(string text) {
            this.noteText = text;
            this.importance = 0;
            this.author = "Anonymous";
        
        }
        public Note(String text, int importance, String author)
        {
            this.noteText = text;
            this.importance = importance;
            this.author = author;
        }

        public string NoteText
        {
            get { return this.noteText; }
            set { this.noteText = value; }
        }
        public int Importance
        {
            get { return this.importance; }
            set { this.importance = value; }
        }
        public string Author
        {
            get { return this.author; }
            private set { this.autor = value; }
        }

        public void setText(String text)
        {
            this.noteText = text;
        }
        public void setImportance(int importance)
        {
            this.importance = importance;
        }
        public String getText()
        {
            return this.noteText;
        }
        public int getImportance()
        {
            return this.importance;
        }
        public String getAuthor()
        {
            return this.author;
        }
        public override string ToString()
        {
            return "Author: "+this.Author + "\n" +"Text: "+ this.NoteText + "\n"+"Importance: " + this.importance;
        }
    }
}
