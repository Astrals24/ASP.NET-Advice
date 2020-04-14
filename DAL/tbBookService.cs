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

        /// <summary>
        /// 添加书籍信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int addBook(tbBook book)
        {
            String sql = string.Format("insert into tbBook values('{0}','{1}','{2}','{3}')", book.ISBN1, book.BookName1, book.Price1, book.PublicDate1);

            return conn.Excu(sql);

        }

        public int deleteBook(string bookID)
        {
            String sql = string.Format("delete from tbBook where ISBN='{0}'",bookID);

            return conn.Excu(sql);

        }

        public int updateBook(string bookID,string bookName)
        {
            String sql = string.Format("update from tbBook set BookNamne='{0}' where ISBN='{1}'", bookName,bookID);

            return conn.Excu(sql);

        }

    }
}
