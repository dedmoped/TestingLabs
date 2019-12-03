using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    class TakePlace
    {
        [FindsBy(How = How.ClassName, Using = "theme__default__u5Zsw")]
        private IWebElement People;
        [FindsBy(How = How.ClassName, Using = "Select__listItem__2iqJZ")]
        private IWebElement PeopleNumber;
        [FindsBy(How = How.ClassName, Using = "alert_title")]
        private IWebElement Error;


        public TakePlace(IWebDriver Browser)
        {
            PageFactory.InitElements(Browser, this);
            
        }
        public TakePlace ChoosePlace()
        {
            People.Click();
            PeopleNumber.Click();


            return this;
        }
        public string GetError()
        {
            return Error.Text;
        }

    }
}
