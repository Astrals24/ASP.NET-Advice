using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class tbBook
    {
        String ISBN;
        String BookName;
        double Price;
        DateTime PublicDate;

        public tbBook()
        {
        }

        public tbBook(string iSBN, string bookName, double price, DateTime publicDate)
        {
            ISBN = iSBN;
            BookName = bookName;
            Price = price;
            PublicDate = publicDate;
        }

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string BookName1 { get => BookName; set => BookName = value; }
        public double Price1 { get => Price; set => Price = value; }
        public DateTime PublicDate1 { get => PublicDate; set => PublicDate = value; }
    }
}
