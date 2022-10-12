using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicLayerLibrary;
using HelperLibrary;
using WebAPI_Intro.Models;
namespace WebAPI_Intro.Controllers
{
    
    public class EmpController : ApiController
    {
        Employee_Helper empHelper = null;

        public EmpController()
        {
            empHelper = new Employee_Helper();
        }
        // GET api/<controller>
        //public List<Employees> Get()
        //{
        //    //return new string[] { "value1", "value2" };
        //    List<Employee_BAL> empbal = new List<Employee_BAL>(); 
        //    empbal = empHelper.ShowEmployeeList();
        //    List<Employees> emps = new List<Employees>();
        //    foreach (var item in empbal)
        //    {
        //        //Employees emp = new Employees();
        //        emps.Add(new Employees { EmployeeID = item.EmployeeID, FirstName = item.FirstName, LastName = item.LastName, BirthDate = item.BirthDate, Title = item.Title });
        //    }
        //    return emps;

        //}

        public Employees Get()
        {
            return new Employees
            {


                EmployeeID = 1,
                LastName = "Davolio",
                FirstName = "Nancy",
                Title = "Sales Representative",
                BirthDate = new DateTime(1948, 08, 12)
            };
        }

        public Employees GetEmpByID(int id)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal = empHelper.SearchEmployee(id);
            Employees emp = new Employees();
            emp.EmployeeID = empbal.EmployeeID;
            emp.FirstName = empbal.FirstName;
            emp.LastName = empbal.LastName;
            emp.Title = empbal.Title;
            emp.BirthDate = empbal.BirthDate;
            return emp;
            //return "value";
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}
        public HttpResponseMessage PostProduct([FromBody] Employees empdata)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal.EmployeeID = empdata.EmployeeID;
            empbal.FirstName = empdata.FirstName;
            empbal.LastName = empdata.LastName;
            empbal.Title = empdata.Title;
            empbal.BirthDate = empdata.BirthDate;


            bool ans = empHelper.AddEmployee(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }

        // PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}
        //public HttpResponseMessage PutProduct(int id, [FromBody] Employees empdata)
        //{

        //    Employee_BAL empbal = new Employee_BAL();
        //    empbal.EmployeeID = empdata.EmployeeID;
        //    empbal.FirstName = empdata.FirstName;
        //    empbal.LastName = empdata.LastName;
        //    empbal.Title = empdata.Title;
        //    empbal.BirthDate = empdata.BirthDate;

        //    bool ans = empHelper.EditEmployee(id, empbal);
        //    if (ans)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotAcceptable);
        //    }
        //}

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        public HttpResponseMessage DeleteProduct(int id)
        {
            bool ans = empHelper.RemvoeEmployee(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }

        }
    }
}