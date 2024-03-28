

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace SevenInkAutomation.Pages
{
    public class aTestingHomePage
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            ActionsClass.InitializeDriver();
            Thread.Sleep(1000);
        }

        [Test]
        public void aGetStartedHomeButton()
        {

            Menu menu = new Menu();
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(menu.GetStartedHomeButton).Build().Perform();
            Thread.Sleep(1500);
            menu.GetStartedHomeButton.Click();
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);

        }

        [Test]
        public void bBookingAMeeting()
        {
            ActionsClass.BookAMeeting();
            Thread.Sleep(2000);
        }

        [Test]
        public void cHoverToPicOne()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.HomePicOne);
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomePicOne).Build().Perform();
            Thread.Sleep(1000);
        }
        [Test]
        public void dHoverToPicTwo()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            actions.MoveToElement(menu.HomePicTwo).Build().Perform();
            Thread.Sleep(1000);
        }

        [Test]
        public void eHoverToPicThree()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            actions.MoveToElement(menu.HomePicThree).Build().Perform();
            Thread.Sleep(2000);
        }

        [Test]
        public void fFindOutMoreHomeButton()
        {

            Menu menu = new Menu();
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(menu.FindOutMoreHome).Build().Perform();
            Thread.Sleep(1000);
            menu.FindOutMoreHome.Click();
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);

        }

        [Test]
        public void gHoverToSentence()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.WhatWeCanDoForYouHome);
            Thread.Sleep(1000);
            actions.MoveToElement(menu.WhatWeCanDoForYouHome).Build().Perform();
            Thread.Sleep(2000);
        }

        [Test]
        public void hSlidePrev()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            menu.SlidePrev.Click();
            Thread.Sleep(1000);
        }

        [Test]
        public void iFindOutMoreSlideOne()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            menu.FindOutMoreSlideOne.Click();
            Thread.Sleep(3000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);
        }

        [Test]
        public void jFindOutMoreSlideTwo()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            menu.SlideNext.Click();
            Thread.Sleep(1000);
            menu.FindOutMoreSlideTwo.Click();
            Thread.Sleep(3000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);
        }

        [Test]
        public void kFindOutMoreSlideThree()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            menu.SlideNext.Click();
            Thread.Sleep(1000);
            menu.FindOutMoreSlideThree.Click();
            Thread.Sleep(3000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);
        }

        [Test]
        public void lFindOutMoreSlideFour()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            menu.SlideNext.Click();
            Thread.Sleep(1000);
            menu.FindOutMoreSlideFour.Click();
            Thread.Sleep(3000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);
        }

        [Test]
        public void mInsightsHomeOne()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.InsightTitle);
            Thread.Sleep(1000);
            actions.MoveToElement(menu.InsightsHomeOne).Build().Perform();
            Thread.Sleep(1000);
            menu.InsightsHomeOne.Click();
            Thread.Sleep(3000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(1000);
        }

        [Test]
        public void nInsightsHomeTwo()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            actions.MoveToElement(menu.InsightsHomeTwo).Build().Perform();
            Thread.Sleep(1000);
            menu.InsightsHomeTwo.Click();
            Thread.Sleep(3000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(2000);
        }
         
        [Test]
        public void oHomeFlower()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.HomeLogo);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.HomeFlowerOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerTwo).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerThree).Build().Perform();
            Thread.Sleep(1000);

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.HomeFlowerFour);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.HomeFlowerFour).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerFive).Build().Perform();
            Thread.Sleep(1000);

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.HomeFlowerSix);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.HomeFlowerSix).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerSeven).Build().Perform();
            Thread.Sleep(1000);

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.InsightTitle);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.HomeFlowerEight).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerNine).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerTen).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.HomeFlowerEleven).Build().Perform();
            Thread.Sleep(1000);

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.FooterFlowerOne);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.FooterFlowerOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.FooterFlowerTwo).Build().Perform();
            Thread.Sleep(1000);

        }


        [OneTimeTearDown]
        public void ZCleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
