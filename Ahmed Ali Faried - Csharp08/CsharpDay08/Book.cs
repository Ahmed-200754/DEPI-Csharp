using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem08
    internal class Book
    {
        string title;
        string author;

        public Book() { }

        public Book(string _title)
        {
            title = _title;
        }

        public Book(string _title, string _author)
        {
            title = _title;
            author = _author;
        }
    } 
    #endregion
}
