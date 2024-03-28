using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SevenInkAutomation.Pages;
using System;
using System.Drawing;
using System.Threading;

namespace SevenInkAutomation
{
    internal class ActionsClass
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://sevenink.com.au/";
        public static void InitializeDriver()
        {

            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl(BaseURL);
            Driver.WaitForElementUpTo(ElementsWaitingTimeout);

        }


        public static void BookAMeeting()
        {
            Menu menu = new Menu();
            menu.BookAMeeting.Click();
            Thread.Sleep(4000);
            menu.ModalBookX.Click();
            
        }

        public static void FillTheContactForm()
        {
            Menu menu = new Menu();

            menu.YourName.Clear();
            menu.YourName.SendKeys("SampleName");
            menu.YourCompany.Clear();
            menu.YourCompany.SendKeys("Sample Company");
            menu.YourEmail.Clear();
            menu.YourEmail.SendKeys("sample.email@gmail.com");
            menu.YourPhone.Clear();
            menu.YourPhone.SendKeys("1300975");
            menu.YourMessage.Clear();
            menu.YourMessage.SendKeys("Sameple Message");
            menu.SubmitButton.Click();
            Thread.Sleep(3000);
        }

    }
}
