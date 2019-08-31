using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMethodsNamespaces.FavoriteThings
{
    class Book
    {
        readonly int _totalPages;
        readonly string _title;
        int _currentPage;
        bool _completed;

        public Book(int totalPages, string title)
        {
            _totalPages = totalPages;
            _title = title;
        }

        public void Read(int pages)
        {
            if(_currentPage + pages > _totalPages)
            {
                _currentPage = _totalPages;
                _completed = true;
                Console.WriteLine($"You have finished {_title}");
            }
            else
            {
                _currentPage += pages;
                Console.WriteLine($"You are currently on page {_currentPage} of {_title}");
            }
        }

        public void Status()
        {
            if (!_completed)
            {
                Console.WriteLine($"You are currently on page {_currentPage} of {_title}");
            }
            else
            {
                int pagesRemaining = _totalPages - _currentPage;
                Console.WriteLine($"You have {pagesRemaining} pages remaining in {_title}");
            }
        }
    }
}