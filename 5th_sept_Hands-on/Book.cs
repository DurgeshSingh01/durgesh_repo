using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRLibrary
{
	public class Book
	{
		public Book()
		{

		}

		public Book(int id,string name,int price,string author)
		{
			_bookid = id;
			_bookname = name;
			_price = price;
			_author = author;
		}

		
		private int _bookid;

		public int BookID
		{
			get { return _bookid; }
			set { _bookid = value; }
		}

		private string _bookname;

		public string BookName
		{
			get { return _bookname; }
			set { _bookname = value; }
		}
		private int _price;

		public int BookPrice
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _author;

		public string BookAuthor
		{
			get { return _author; }
			set { _author = value; }
		}


        public void InsertBook(int BookID, string BooKName)
        {
            this.BookID = BookID;
            this.BookName = BooKName;

        }



        public void InsertBook(int BookID, string BooKName, int Price)
        {
            this.BookID = BookID;
            this.BookName = BooKName;
            this.BookPrice = Price;

        }

        public void InsertBook(int BookID, string BooKName, int Price, string author )
        {
            this.BookID = BookID;
			this.BookName = BooKName;
			this.BookPrice = Price;
			this.BookAuthor = author;

        }

        public class Novel : Book
        {
            int NoOfPages;
            public void InsertBook(int id, string name, int price, int noofpages)
            {
                this.BookID = id;
                this.BookName = name;
                this.BookPrice = price;
                this.NoOfPages = noofpages;
            }
        }







    }
}
