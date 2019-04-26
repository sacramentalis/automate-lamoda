using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamoda
{
    [TestClass]
    public class TestBase
    {
        protected IWebDriver Driver { get; set; }

        protected GotoPage GotoPage;
        protected BuyProduct BuyProduct;



        [TestInitialize]

        public void TestInit()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            GotoPage = new GotoPage(Driver);
            BuyProduct = new BuyProduct(Driver);
        }

        [TestCleanup]
        public void testShutdown()
        {
            if (Driver != null)

            {
                Driver.Close();
            }
        }


    }
}

