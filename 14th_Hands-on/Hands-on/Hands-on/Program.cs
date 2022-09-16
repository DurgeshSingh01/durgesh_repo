using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CustomerUser;
namespace Hands_on
{
    internal class Program
    {
        public static List<Movie> list = new List<Movie>();
        static void Main(string[] args)
        {

            //UserAuthentication();
            //ReadtheUserDetails();
            Movie movie = new Movie();
            movie.intialmovie();
            FileStream fs2 = new FileStream(@"searchData.xml",FileMode.Create,FileAccess.Write);
            movie.SearchByGeners("Action");
            Console.WriteLine("========================");
            movie.SearchByLanguage("Hindi");
            Console.WriteLine("========================");
            movie.printAllmovie();
            Console.WriteLine("========================");



            XmlSerializer xml = new XmlSerializer(typeof(Movie));   
            xml.Serialize(fs2, movie);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();




            

            Console.ReadLine();



        }

        private static void ReadtheUserDetails()
        {
            FileStream fs1 = new FileStream(@"userData.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter1 = new BinaryFormatter();
            authentication edata = (authentication)formatter1.Deserialize(fs1);
            Console.WriteLine("User Id : " +edata.ID);
            Console.WriteLine("User Password : " +edata.Password);
            Console.WriteLine("Login Status : " +edata.Status);
            Console.WriteLine("Login time : " +edata.date);
            fs1.Flush();
            fs1.Close();
            fs1.Dispose();
        }

        private static void UserAuthentication()
        {
            authentication at = new authentication();
            Console.WriteLine("==============================");
            Console.WriteLine("User Authentications");
            Console.Write("Enter the User Id: ");
            at.ID = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the User Password: ");
            at.Password = Console.ReadLine();
            at.date = DateTime.Now;
            at.doauthentication(at.ID, at.Password);

            FileStream fs = new FileStream(@"userData.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, at);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
    }
}
