using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Silenium
{
    [TestClass]
    public class Tutu_Tests
    {
        [TestMethod]
        public void TestDate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tutu.ru");
            driver.FindElement(By.ClassName("j-station_input_from")).SendKeys("Гомель");
            driver.FindElement(By.ClassName("j-station_input_to")).SendKeys("Молодечно");
           driver.FindElement(By.ClassName("j-date_to")).SendKeys("3.10.2019");
           driver.FindElement(By.ClassName("m-border_inner")).Click();
          Assert.AreEqual("Выберите день,чтобы найти ж/д билеты Гомель - Пасс. → Молодечно", driver.FindElement(By.ClassName("t-ttl")).Text);
           driver.Quit();
        }

        [TestMethod]
        public void TestArrivedPlace()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tutu.ru");
            driver.FindElement(By.ClassName("j-station_input_from")).SendKeys("Гродно");
            driver.FindElement(By.ClassName("j-station_input_to")).SendKeys("");
            driver.FindElement(By.ClassName("j-date_to")).SendKeys("30.11.2019");
            driver.FindElement(By.ClassName("m-border_inner")).Click();
            Assert.AreEqual("Пожалуйста, укажите название станции", driver.FindElement(By.ClassName("j-popup-content")).Text);
            driver.Quit();
        }
    }
}
    

