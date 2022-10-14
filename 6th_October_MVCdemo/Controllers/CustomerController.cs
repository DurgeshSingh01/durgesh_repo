using MVCdemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<CustModel> custs = new List<CustModel>();
            custs.Add(new CustModel { Custid = 101, Custname = "Durgesh", City = "Noida" });
            custs.Add(new CustModel { Custid = 102, Custname = "Archit", City = "Moradabad" });
            custs.Add(new CustModel { Custid = 103, Custname = "Harshit", City = "Lucknow" });

            return View(custs);
        }

        public ActionResult AcceptData()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AcceptData(CustModel model)
        {
            CustModel c = new CustModel();
            c.Custid = model.Custid;
            c.Custname = model.Custname;
            c.City = model.City;
            return View();
        }


        public ActionResult AddData()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddData(FormCollection customer)
        {

            CustModel c = new CustModel();

            c.Custid = Convert.ToInt32(Request.Form["Custid"]);
            c.Custname = customer["Custname"].ToString();
            c.City = customer["City"].ToString();
            return View();
        }


        public ActionResult AddNos()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddNos(int i, int j)
        {
            int ans = i + j;
            return Content(ans.ToString());
        }
        public ActionResult CustData()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CustData(int id, string name, string city)
        {
            CustModel c = new CustModel();
            c.Custid = id;
            c.Custname = name;
            c.City = city;
            //passing the values using the route parameter
            //route parameter is declared in Route.config(App_Start Folder)

            return RedirectToAction("FindCust", new { custid = c.Custid, name = c.Custname });
        }


        public ActionResult FindCust(int custid, string cname)
        {
            string s = null;
            string gotname = cname;
            if (custid != 0)
            {
                s = "trying to find customer by its id";
            }
            return Content(s);
        }
    }
}