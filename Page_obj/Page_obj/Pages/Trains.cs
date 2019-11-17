using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Page_obj.Pages
{
    class Trains
    {
        [FindsBy(How = How.ClassName, Using = "_blue")]
        private IWebElement First_Train;
        public Trains(IWebDriver Browser)
        {
            PageFactory.InitElements(Browser,this);
        }
        public Trains Takefirst()
        {
            First_Train.Click();

            return this;
        }

    }
}
