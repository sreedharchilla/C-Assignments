using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    struct Books
    {
        public string Name;
        private int BookId { get; set; }

        public int BookID
        {
            get
            {
                return BookId;
            }
            set
            {
                BookId = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Book Id Is :{0}", BookId);
            Console.WriteLine("Book name is :{0}", Name);
        }


    }
    class StructEg1
    {
        static void Main()
        {
            Books b = new Books();
            b.BookID = 345;
            b.Name = "Reality of Life";
            b.Display();
            Console.ReadLine();
        }
    }
}
