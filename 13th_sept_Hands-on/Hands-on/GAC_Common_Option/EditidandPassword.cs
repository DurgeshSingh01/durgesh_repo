using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonOptions_GAC
{
    public class EditidandPassword
    {

        
        public static void ChangePw()
        {

            string new_pw = Console.ReadLine();

        }
        public EditidandPassword()
        {
            
        }


        string username, password;





        public void Edit()
        {

            this.username = Console.ReadLine();
            this.password = Console.ReadLine();

        }

        public void View()
        {

            Console.WriteLine(username);
            Console.WriteLine(password);

        }
    }
}