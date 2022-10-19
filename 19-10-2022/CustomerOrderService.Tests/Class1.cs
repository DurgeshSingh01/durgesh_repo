using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void test1()
        {
            Assert.That(1 == 1);
        }

        [TestCase]
        public void When_Premium_10Percent()
        {
            Customer c = new Customer();
            c.CustID = "php";
            c.CustName = "Ramy";
            c.CustomerType = CustomerType.Premium;

            Order o = new Order();
            o.OrderID = 23;
            o.ProductID = 4;
            o.Quantity = 10;
            o.Amount = 1000;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c, o);

            Assert.AreEqual(o.Amount, 900);
        }
        [TestCase]
        public void When_Gold_20Percent()
        {
            Customer c = new Customer();
            c.CustID = "lkl";
            c.CustName = "Ramy";
            c.CustomerType = CustomerType.Gold;

            Order o = new Order();
            o.OrderID = 23;
            o.ProductID = 4;
            o.Quantity = 10;
            o.Amount = 1000;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c, o);

            Assert.AreEqual(o.Amount, 800);
        }

        [TestCase]
        public void FetchList()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            Customer c1 = new Customer();

            customerOrder.GetCustomerList(c1);
            List<Customer> custList1 = new List<Customer>();
            custList1.Add(new Customer() { CustID = "sk", CustName = "sk" });
            custList1.Add(new Customer() { CustID = "ab", CustName = "ab" });
            Assert.AreEqual(custList1, c1.Customers);
        }

       

    }

    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }


    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }
}
