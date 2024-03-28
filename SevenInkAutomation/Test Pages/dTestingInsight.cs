
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SevenInkAutomation.Pages;
using System;
using System.Threading;

namespace SevenInkAutomation.Scenarios
{
    public class dTestingInsight
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
            NavigateTo.InsightsScenario();

        }

        [Test]
        public void bInsightsFlower()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.InsightsFlower);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.InsightsFlower).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.FooterFlowerOne);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.FooterFlowerOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.FooterFlowerTwo).Build().Perform();
            Thread.Sleep(2000);
        }

        [Test]
        public void CHoverInTheSentence()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.InsightTitleBlog);
            Thread.Sleep(2000);
             actions.MoveToElement(menu.Blog1).Build().Perform();
            Thread.Sleep(1000);
            menu.Blog1.Click();
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.Blog2).Build().Perform();
            Thread.Sleep(1000);
            menu.Blog2.Click();
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.Blog1).Build().Perform();
            Thread.Sleep(1000);
            menu.Blog3.Click();
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
            Thread.Sleep(1000);
        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
