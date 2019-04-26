using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamoda
{
    public abstract class PageBase
    {
        protected IWebDriver Driver { get; }
        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
