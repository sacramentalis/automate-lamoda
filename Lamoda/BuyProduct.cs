using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamoda
{
   public class BuyProduct : PageBase
    {
        private const string PAGE_URL = "https://www.lamoda.by/c/369/clothes-platiya/?sf=223&zbs_content=w_text_long_by_2803_icons_w_ss19&base_materials=1&colors=615&size_values=40&brands=&property_neckline=31156";

        IWebElement Product => Driver.FindElement(By.XPath("//span[contains(text(),'Платье')]"));

        IWebElement Size => Driver.FindElement(By.XPath("//div[contains(text(),'Выберите размер')]"));
        IWebElement Price => Driver.FindElement(By.XPath("//div[contains(text(),'40 RUS')]"));
        IWebElement Add => Driver.FindElement(By.XPath("//span[contains(text(),'Добавить в корзину')]"));
        //IWebElement ClosePopup => Driver.FindElement(By.XPath("//span[contains(text(),'close')]"));
        IWebElement Bucket => Driver.FindElement(By.XPath("//a[contains(text(),'Перейти в корзину')]"));
        IWebElement Phone => Driver.FindElement(By.XPath("//input[@name='phone')]"));
        IWebElement Punct => Driver.FindElement(By.XPath("//input[@name='city_name')]"));
        IWebElement Name => Driver.FindElement(By.XPath("//input[@name='first_name')]"));
        IWebElement LastName => Driver.FindElement(By.XPath("//input[@name='last_name')]"));
        IWebElement Email => Driver.FindElement(By.XPath("//input[@name='email')]"));
        IWebElement Comment => Driver.FindElement(By.XPath("//input[@name='customer_notes')]"));
        IWebElement Send => Driver.FindElement(By.XPath("//button[contains(text(),'Отправить заказ')]"));
        

        public BuyProduct(IWebDriver driver) : base(driver)
        {
        }


            public void GotoLoginPage()
            {
                Driver.Navigate().GoToUrl(PAGE_URL);
            }


            public void Product1()
        {

            Product.Click();
            Size.Click();
            Price.Click();
            Add.Click();
            //ClosePopup.Click();
            Bucket.Click();
           
        }
        public void Form (string phone, string punct, string name, string lastname, string email, string comment)
        {
            Phone.SendKeys(phone);
            Punct.SendKeys(punct);
            Name.SendKeys(name);
            LastName.SendKeys(lastname);
            Email.SendKeys(email);
            Comment.SendKeys(comment);
        }

        public void SendForm()
        {
            Send.Click();
        }
    }
}
