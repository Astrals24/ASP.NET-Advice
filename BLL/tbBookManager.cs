using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BLL;
using Model;

namespace BLL
{
    public class tbBookManager
    {
        tbBookService bookService = new tbBookService();

        public bool addBook(tbBook book)
        {
            if (bookService.addBook(book) > 0)
                return true;

            return false;

        }


    }
}
