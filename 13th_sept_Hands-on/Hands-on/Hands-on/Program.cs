using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserClass;
using AdminClass;
using System.Collections;

namespace Hands_on
{
    internal class Program
    {
        static void Main(string[] args)
        {
            authentication at = new authentication();
            Console.WriteLine("==============================");
            Console.WriteLine("User Authentications");
            Console.Write("Enter the User Id: ");
            at.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the User Password: ");
            at.Password = Console.ReadLine();
            at.doauthentication(at.ID,at.Password);

            Movie m1 = new Movie();
            m1.AddMovie("Bramastra", "Hindi", "Action", 1000);
            Movie m2 = new Movie();
            m2.AddMovie("Spider Man- No Way Home", "English", "Action", 2000);
            Movie m3 = new Movie();
            m3.AddMovie("Avenger-Infinity", "English", "Action", 2000);
            Movie m4 = new Movie();
            m4.AddMovie("Avenger-End Game", "English", "Action", 2000);
            Movie m5 = new Movie();
            m5.AddMovie("Thor", "English", "Action", 2000);
            Movie m6 = new Movie();
            m6.AddMovie("Phir Hera Pheri", "Hindi", "Comedy", 5000);
            Movie m7 = new Movie();
            m7.AddMovie("Golmaal", "Hindi", "Comedy", 5000);
            Movie m8 = new Movie();
            m8.AddMovie("Malamaal", "Hindi", "Comedy", 5000);
            Movie m9 = new Movie();
            m9.AddMovie("Dhoom", "Hindi", "Action", 1000);
            Movie m10 = new Movie();
            m10.AddMovie("Ra.One", "Hindi", "Action", 1000);



            Movie m = new Movie();
            //m.intialmovie();
            Console.WriteLine("==============================");
            Console.WriteLine("Top 10 trending movie: ");
            m.printAllmovie();
            Console.WriteLine("==============================");

            Console.WriteLine("Enter Movie's Language You want to search: ");
            m.SearchByLanguage(Console.ReadLine());
            Console.WriteLine("==============================");

            Console.WriteLine("Enter Movie's Geners You want to search: ");
            m.SearchByGeners(Console.ReadLine());
            Console.WriteLine("==============================");

            User u = new User(User.Level.Silver);
            u.borrow(m1);
            u.borrow(m1);
            u.borrow(m1);


            u.m_return(m1, 10);

            u.borrow(m2);  //done

            u.borrow(m3);   // err msg

            u.m_return(m2, 2);

            Console.WriteLine($"Count of borrowed movies {u.borrowed_movies.Count}");







            Console.ReadLine();
        }
    }
}
