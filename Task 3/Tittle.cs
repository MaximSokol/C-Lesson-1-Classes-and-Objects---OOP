using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_
{
    class Tittle
    {
        string tittle;
        //--------------------------------

        public Tittle(string tittle)
        {
            this.tittle = tittle;
        }
        //--------------------------------

        public void ShowTittle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(tittle);
        }
        //--------------------------------
    }
}
