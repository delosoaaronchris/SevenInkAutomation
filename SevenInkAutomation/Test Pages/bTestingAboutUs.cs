using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Threading;


namespace SevenInkAutomation.Pages
{
    public class bTestingAboutUs
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
            NavigateTo.AboutUsScenario();

        }

        [Test]
        public void bAboutUsFlower()
        {

            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            actions.MoveToElement(menu.AboutFlowerOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.AboutFlowerTwo).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.AboutFlowerThree);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.AboutFlowerThree).Build().Perform();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.AboutFlowerFour);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.AboutFlowerFour).Build().Perform();
            Thread.Sleep(1000);

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", menu.FooterFlowerOne);
            Thread.Sleep(2000);
            actions.MoveToElement(menu.FooterFlowerOne).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.FooterFlowerTwo).Build().Perform();
            Thread.Sleep(1000);

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
