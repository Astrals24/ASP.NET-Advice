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

        /// <summary>
        /// 添加书籍信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool addBook(tbBook book)
        {
            if (bookService.addBook(book) > 0)
                return true;

            return false;

        }


        public bool deleteBook(string bookID)
        {
            if (bookService.deleteBook(bookID) > 0)
                return true;

            return false;

        }

        public bool updateBook(string bookID,string bookName)
        {
            if (bookService.updateBook(bookID,bookName) > 0)
                return true;

            return false;

        }
    }
}
