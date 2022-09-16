using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUser
{
    [Serializable()]
    public class authentication
    {
        public double _id;

        public double ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool _status;

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public DateTime date { get; set; }


        public void doauthentication(double id, string pass)
        {
            if (id == 7510042801 && pass == "Durgesh@1417")
            {
                Console.WriteLine("Login Successfully....");
                Status = true;
            }
            else
            {
                Console.WriteLine("Please Enter a valid Id and Password...");
                Status = false;
                Environment.Exit(0);
            }

        }



    }

    [Serializable()]
    public class Movie
    {
        private string _moviename;

        public string MovieName
        {
            get { return _moviename; }
            set { _moviename = value; }
        }

        private string _language;

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        private string _geners;

        public string Geners
        {
            get { return _geners; }
            set { _geners = value; }
        }

        private int _cost;

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public int AvailableStock;

        public int Availablestock
        {
            get { return AvailableStock; }
            set { AvailableStock = value; }
        }


        public static int Moviecount = 0;
        public static List<Movie> MoviesList = new List<Movie>();
        public void AddMovie(string name, string language, string geners, int cost)
        {
            this.MovieName = name;
            this.Language = language;
            this.Geners = geners;
            this.Cost = cost;
            AvailableStock = 10;
            MoviesList.Add(this);
            Moviecount++;

        }

        public void printAllmovie()
        {
            foreach (Movie items in MoviesList)
            {
                Console.WriteLine(items.MovieName);
            }

        }

        public void SearchByLanguage(string language)
        {
            int count = 0;
            foreach (var item in MoviesList)
            {

                if (item.Language == language)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.Geners}");
                    count++;
                }


            }
            if (count == 0)
            {
                Console.WriteLine("No Movie Available in this language...");
            }
        }

        public void SearchByGeners(string Geners)
        {
            int count = 0;
            foreach (var item in MoviesList)
            {

                if (item.Geners == Geners)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.Geners}");
                    count++;
                }


            }
            if (count == 0)
            {
                Console.WriteLine("No Movie Available in this Geners...");
            }
        }

        public void intialmovie()
        {
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
        }




    }

    public class User
    {

        public enum Level

        {
            Silver = 2,
            Gold = 3,
            Platinum = 5

        }

        public List<Movie> borrowed_movies;
        public User(Level lvl)
        {

            UserLevel = (int)lvl;
            borrowed_movies = new List<Movie>();
        }

        public int borrow_num = 0;
        public void borrow(Movie m)
        {
            if (m.AvailableStock > 0)
            {
                if (this.borrow_num < UserLevel)
                {
                    borrowed_movies.Add(m);
                    borrow_num++;
                    m.AvailableStock--;
                    Console.WriteLine("=>Borrowed successfully");

                }
                else
                {
                    Console.WriteLine($"{(Level)UserLevel} limit reached");
                }

            }
            else
            {
                Console.WriteLine("Movie is out of stock");
            }

        }

        public void m_return(Movie m, int days)
        {
            if (borrowed_movies.Contains(m))
            {

                borrowed_movies.Remove(m);
                m.AvailableStock++;
                borrow_num--;

                double totalcost = days * m.Cost;

                Console.WriteLine($"Cost to be paid :Rs{totalcost}");
                Console.WriteLine("-->Returned successfully");
            }
        }



        public int UserLevel { get; set; }



    }
}
