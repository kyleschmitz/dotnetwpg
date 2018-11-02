using System;
using System.Collections.Generic;
using System.Text;

namespace Bicycle
{
    class Bicycle
    {
        private static int _lastId = 0;

        public readonly int _id;

        public int Id
        {
            get { return _id; }
        }

        public Bicycle()
        {
            _lastId++;
            _id = _lastId;
        }

        public static int GetLastId()
        {
            return _lastId;
        }
    }
}