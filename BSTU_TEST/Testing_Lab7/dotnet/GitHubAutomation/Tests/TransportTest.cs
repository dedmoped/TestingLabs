using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework.Driver;
using Framework.Pages;
using Framework.Services;
using Framework.Tests;

namespace Framework
{
    
    class TransportTest: TestConfig
    {
        [Test]
        public void TestStation()
        {
            Browser.Navigate().GoToUrl("https://www.tutu.ru/");
            HomePage homePage = new HomePage(Browser).InpuntInformation(CreateWay.GetTestStationInfo());
            HomePage home = new HomePage(Browser);
            Assert.AreEqual("Пожалуйста, укажите название станции",homePage.GetError());
        }
        [Test]
        public void TestNumberOfPeople()
        {
            Browser.Navigate().GoToUrl("https://www.tutu.ru/");
            TakePlace homePage = new HomePage(Browser).InpuntInformationAndMoveTo(CreateWay.GetPeopleNumberInfo()).Takefirst().ChoosePlace(); 
            Assert.AreEqual("Вы не выбрали ни одного пассажира", homePage.GetError());
        }
        
       
    }

}
