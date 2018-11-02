using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample
{
    class President
    {
        public static President CurrentPresident { get; private set; }

        static President()
        {
            CurrentPresident = new President();
        }

        public string Name { get; set; }
        public int YearsInOffice { get; set; }
        
        private President()
        {

        }
    }
}
