using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_
{
    class Author
    {
        string author;
        //--------------------------------

        public Author(string author) 
        {
            this.author = author; 
        }
        //--------------------------------

        public void ShowAuthor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }
        //--------------------------------
    }
}
