using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern.Example_01
{
    // ConcreteIterator
    public class BookIterator : Iterator
    {
        private BookCollection _books;
        private int _current = 0;
        public BookIterator(BookCollection books)
        {
            _books = books;
        }
        public override string First()
        {
            return _books[0];
        }
        public override string Next()
        {
            _current++;
            if (IsDone())
                return null;
            else
                return _books[_current];
        }
        public override bool IsDone()
        {
            return _current >= _books.Count;
        }
        public override string CurrentItem()
        {
            return _books[_current];
        }
    }

}
