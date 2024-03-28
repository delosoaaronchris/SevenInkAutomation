
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SevenInkAutomation.Pages;
using System;
using System.Threading;

namespace SevenInkAutomation.Scenarios
{
    public class eTestingContactUs
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
            NavigateTo.ContactUsScenario();
            Thread.Sleep(2000);
        }

        [Test]
        public void bContactFlower()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            actions.MoveToElement(menu.ContactFlower1).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.ContactFlower2).Build().Perform();
            Thread.Sleep(1000);
            actions.MoveToElement(menu.ContactFlower3).Build().Perform();
            Thread.Sleep(1000);

        }

        [Test]
        public void cSubmitSample()
        {
            Actions actions = new Actions(Driver.driver);
            Menu menu = new Menu();
            ActionsClass.FillTheContactForm();
            Thread.Sleep(2000);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
