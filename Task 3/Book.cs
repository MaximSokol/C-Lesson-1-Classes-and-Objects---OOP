using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_
{
    class Book
    {
        Tittle tittle = null;
        Author author = null;
        Content content = null;
        //----------------------------------------------------------------

        public Book(Tittle tittle, Author author, Content content)
        {
            this.tittle = tittle;
            this.author = author;
            this.content = content;
        }
        //----------------------------------------------------------------

        public void ShowDateBook()
        {
            tittle.ShowTittle();
            author.ShowAuthor();
            content.ShowContent(); 
        }
        //----------------------------------------------------------------
    }
}
