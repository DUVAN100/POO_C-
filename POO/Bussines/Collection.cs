using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Bussines
{
    public class Collection<T>
    {
        private T[] _elemnts;
        private int _index;
        private int _limit;

        public Collection(int limit) 
        {
            _index = 0;
            _limit = limit;
            _elemnts = new T[limit];
        }
        public void Add(T element) 
        {
            if (_index < _limit) 
            {
                _elemnts[_index++] = element;
            }
        }

        public T[] Get() => _elemnts;
    }
}
