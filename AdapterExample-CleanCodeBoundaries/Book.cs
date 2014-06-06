using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample_CleanCodeBoundaries
{
    class Book
    {
        public string Title { get; set; }
        public int PageNumer { get; set; }
        public List<string> KeyWords { get; set; }
    }
}
