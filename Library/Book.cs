using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
    class Textbook : Book
    {
        public string Subject { get; set; }
        public int Difficulty { get; set; }
        internal Textbook(string title, string author, int pages, string subject, int difficulty) : base(title, author, pages)
        {
            Subject = subject;
            Difficulty = difficulty;
        }
    }
    class Kids : Book
    {
        public byte ChildOrTeen { get; set; }
        public bool Pictures { get; set; }
        internal Kids(string title, string author, int pages, byte childOrTeen, bool pictures) : base( title, author, pages)
        {
            ChildOrTeen = childOrTeen;
            Pictures = pictures;
        }
    }
    class Fiction : Book
    {
        public string Genre { get; set; }
        public byte RomanceOrAnthology { get; set; }
        internal Fiction(string title, string author, int pages, string genre, byte romanceOrAnthology) : base(title, author, pages)
        {
            Genre = genre;
            RomanceOrAnthology = romanceOrAnthology;
        }
    }
}
