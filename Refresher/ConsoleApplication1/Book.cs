using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        // -------------------------- Construtor
        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
