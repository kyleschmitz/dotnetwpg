
namespace InClassAssignment
{
    class Book
    {
        private string _title;
        private string _author;
        private int _maxCopies;
        private int _lentCopies;
        
        public Book()
        {
            _title = "Default";
            _author = "Author";
            _maxCopies = 0;
            _lentCopies = 0;
        }

        public Book(string title, string author, int maxCopies)
        {
            _title = title;
            _author = author;
            _maxCopies = maxCopies;
            _lentCopies = 0;
        }

        public bool LendCopy()
        {
            if (_lentCopies < _maxCopies)
            {
                _lentCopies++;
                return true;
            }
            return false;
        }

        public bool Return()
        {
            if (_lentCopies > 0)
            {
                _lentCopies--;
                return true;
            }
            return false;
        }

        public string GetString()
        {
            return $"{_title}, by {_author}. {_lentCopies} copies lent out from {_maxCopies} total.";
        }
    }
}
