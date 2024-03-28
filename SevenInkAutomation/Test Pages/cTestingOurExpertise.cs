

using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SevenInkAutomation.Pages;
using System;
using System.Threading;

namespace SevenInkAutomation.Scenarios
{
    public class cTestingOurExpertise
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            ActionsClass.InitializeDriver();
            Thread.Sleep(1000);
        }

        [Test]
        public void aGoToPage()
        {
            Thread.Sleep(1000);
            NavigateTo.OurExpertiseScenario();

        }

        [Test]
        public void bOurExpertiseFlower()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            actions.MoveToElement(menu.OurExpertiseOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.OurExpertiseTwo).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.OurExpertiseThree);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.OurExpertiseThree).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.OurExpertiseFour);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.OurExpertiseFour).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.OurExpertiseFive);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.OurExpertiseFive).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.OurExpertiseSix);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.OurExpertiseSix).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.FooterFlowerOne);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.FooterFlowerOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.FooterFlowerTwo).Build().Perform();
            Thread.Sleep(1000);

        }

        [Test]
        public void cHoverTheSentence()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.OurExpertiseHighlightSentence);
            Thread.Sleep(1000);
            actions.MoveToElement(menu.OurExpertiseHighlightSentence).Build().Perform();
            Thread.Sleep(2000);
        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
