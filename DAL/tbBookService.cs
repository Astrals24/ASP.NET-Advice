using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;


namespace DAL
{
    public class tbBookService
    {
        OleDbServerConn conn = new OleDbServerConn();

        public int addBook(tbBook book)
        {
            String sql = string.Format("insert into tbBook values('{0}','{1}','{2}','{3}')", book.ISBN1, book.BookName1, book.Price1, book.PublicDate1);


            return conn.Excu(sql);

        }




    }
}
