using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BookOperations
    {
        public List<BookBAl> ShowAllBooks()
        {
            LibraryEntities lb = new LibraryEntities();
            
            List<Book>  bk = lb.Books.ToList();
            List<BookBAl> bl = new List<BookBAl>();

            foreach (var item in bk)
            {
                bl.Add(new BookBAl {Book_NO=item.Book_No, Book_Name=item.Book_Name,Author=item.Author,Cost=item.Cost,Category=item.Category  });



            }
            return bl;

        }
        public void insertBook(BookBAl bal)
        {
            LibraryEntities le = new LibraryEntities();
            Book b = new Book();
            b.Book_No = bal.Book_NO;
            b.Book_Name = bal.Book_Name;
            b.Author = bal.Author;
            b.Cost = bal.Cost;
            b.Category = bal.Category;
            le.Books.Add(b);
            le.SaveChanges();
            Console.WriteLine("Book Inserted Successfully...");


        }

        public void UpdateBook(BookBAl bal)
        {
            LibraryEntities le = new LibraryEntities();
            List<Book> bk = le.Books.ToList();
            Book b = bk.Find(id => id.Book_No == bal.Book_NO);
            b.Book_Name = bal.Book_Name;
            b.Author = bal.Author;
            b.Cost = bal.Cost;
            b.Category = bal.Category;
            le.SaveChanges();
            Console.WriteLine("Book Updated Successfully...");

        }

        public void DeleteBook(int BookNo)
        {

            LibraryEntities le = new LibraryEntities();
            le.sp_deletebook(BookNo);
            le.SaveChanges();
            
        }

        public void CountBook()
        {
            LibraryEntities le = new LibraryEntities();
            //le.sp_deletebook();
        }

    }
}
