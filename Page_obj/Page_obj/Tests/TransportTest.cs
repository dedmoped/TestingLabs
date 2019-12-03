using System;
using System.Collections;
using Page_obj.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Page_obj
{
    [TestClass]
    public class TransportTest
    {
        [TestMethod]
        public void TestStation()
        {
            IWebDriver Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl("https://www.tutu.ru/");
            HomePage homePage = new HomePage(Browser).InpuntInformation("Гродно","","30.11.2019");
            Assert.AreEqual("Пожалуйста, укажите название станции",homePage.GetError());
           Browser.Quit();
        }
        [TestMethod]
        public void TestNumberOfPeople()
        {
            IWebDriver Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl("https://www.tutu.ru/");
            HomePage homePage = new HomePage(Browser).InpuntInformation("Санкт-Петербург", "Москва", "30.11.2019");
            Trains trains = new Trains(Browser).Takefirst();
            ChangeWindow(Browser);
            TakePlace takePlace = new TakePlace(Browser).ChoosePlace();
            Assert.AreEqual("Вы не выбрали ни одного пассажира", homePage.GetError());
            Browser.Quit();
        }
        
        private void ChangeWindow(IWebDriver Browser)
        {
            List<string> arrayList = new List<string>(Browser.WindowHandles);
            Browser.SwitchTo().Window(arrayList[0]);
            Browser.Close();
            Browser.SwitchTo().Window(arrayList[1]);
        }
    }

}
