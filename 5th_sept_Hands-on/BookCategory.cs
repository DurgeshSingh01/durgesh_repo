using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class BookCategory
    {

		public BookCategory()
		{

		}


        public BookCategory(int id, string name, string des)
        {
			_catid = id;
			_catname = name;
			_description = des;

        }






        private int _catid;

		public int CategoryId
		{
			get { return _catid; }
			set { _catid = value; }
		}

		private string _catname;

		public string CategoryName
		{
			get { return _catname; }
			set { _catname = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}


        


    }
}
