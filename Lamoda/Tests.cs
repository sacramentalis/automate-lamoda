using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lamoda
{
    [TestClass]
    public class Tests : TestBase
    {
        [TestMethod]
        public void GotoPAge()

        {
            GotoPage.GoToPage();
            GotoPage.ClickingIcon();
            GotoPage.FilterClick();
            Thread.Sleep(700);
            GotoPage.FilterClick1();
            Thread.Sleep(800);
            GotoPage.FilterClick2();
            Thread.Sleep(800);
            GotoPage.FilterClick3();
            var isFindtrue = GotoPage.IsFindtrue();
            Assert.IsTrue(isFindtrue);
        }

        [TestMethod]
        public void Product()
        {
            BuyProduct.GotoLoginPage();
            BuyProduct.Product1();
            BuyProduct.Form("235354", "test", "test", "test", "test", "test");
            BuyProduct.SendForm();
        }


    }
}
