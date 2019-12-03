using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Framework.model;

namespace Framework.Pages
{
    class HomePage
    {
        private IWebDriver Browser;
        [FindsBy(How=How.Name, Using = "schedule_station_from")] 
        private IWebElement Station_from;
        [FindsBy(How = How.Name, Using = "schedule_station_to")]
        private IWebElement Station_to;
        [FindsBy(How = How.ClassName, Using = "j-date_to")]
        private IWebElement Date;
        [FindsBy(How = How.ClassName, Using = "m-border_inner")]
        private IWebElement Find;
        [FindsBy(How = How.ClassName, Using = "j-popup-content")]
        private IWebElement Station_Error;

        public HomePage(IWebDriver Browser)
        {
            this.Browser = Browser;
            PageFactory.InitElements(Browser, this);
        }
        
        public Trains InpuntInformationAndMoveTo(Way way)
        {
            Station_from.SendKeys(way.DepartureCity);
            Station_to.SendKeys(way.ArrivalCity);
            Date.SendKeys(way.Departure_date);
            Date.Click();
            Find.Click();
            return new Trains(Browser);
        }
        public HomePage InpuntInformation(Way way)
        {
            Station_from.SendKeys(way.DepartureCity);
            Station_to.SendKeys(way.ArrivalCity);
            Date.SendKeys(way.Departure_date);
            Date.Click();
            Find.Click();
            return this;
        }
        public string GetError()
        {
            return Station_Error.Text;
        }
        
    }
}
