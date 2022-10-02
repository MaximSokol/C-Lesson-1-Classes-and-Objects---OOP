using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_
{
    class Content
    {
        string content;
        //--------------------------------

        public Content(string content)
        {
            this.content = content;
        }
        //--------------------------------

        public void ShowContent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
        }
        //--------------------------------
    }
}
