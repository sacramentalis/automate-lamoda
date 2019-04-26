using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamoda
{
    public class GotoPage : PageBase
    {
        private const string GOTOPAGE = "https://www.lamoda.by/women-home/";

        IWebElement SelectDress => Driver.FindElement(By.XPath("//span[contains(text(),'Платья')]"));
        IWebElement Filter => Driver.FindElement(By.XPath("//span[contains(text(),'Материалы')]"));

        IWebElement SelectFilter => Driver.FindElement(By.XPath("//label [@class='multifilter-item__label']"));
        IWebElement ButtonSend => Driver.FindElement(By.XPath("//span[contains(text(),'Применить')]"));
        IWebElement Filter1 => Driver.FindElement(By.XPath("//span[contains(text(),'Цвет')]"));
        IWebElement SelectFilter1 => Driver.FindElement(By.XPath("//label[contains(text(),'белый')]"));

        IWebElement Filter2 => Driver.FindElement(By.XPath("//span[contains(text(),'Размер')]"));
        IWebElement SelectFilter2 => Driver.FindElement(By.XPath("//label[contains(text(),'40')]"));
        IWebElement Filter3 => Driver.FindElement(By.XPath("//span[contains(text(),'Вырез/воротник')]"));
        IWebElement Searchfield => Driver.FindElement(By.XPath("//label[contains(text(),'хомут')]"));
        IWebElement Filter4 => Driver.FindElement(By.XPath("//span[contains(text(),'Цена')]"));
        IWebElement ResultTest => Driver.FindElement(By.XPath("//span[contains(text(),' 1 товар ')]"));

        public GotoPage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl(GOTOPAGE);
        }

        public void ClickingIcon()
        {
            SelectDress.Click();
        }

        public void FilterClick()
        {
            Filter.Click();
            SelectFilter.Click();
            ButtonSend.Click();

        }

        public void FilterClick1()
        {
            Filter1.Click();
            SelectFilter1.Click();
            Filter2.Click();
        }


        public void FilterClick2()
        {
            Filter2.Click();
            SelectFilter2.Click();
            Filter3.Click();

        }

        public void FilterClick3()
        {
            Filter3.Click();
            Searchfield.Click();
            Filter4.Click();
        }

        public bool IsFindtrue()
        {
            var ProductTest = ResultTest.Text.Equals("1 товар");
            return ProductTest;

        }



    }
}

