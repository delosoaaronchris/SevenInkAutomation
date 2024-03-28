using SevenInkAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenInkAutomation
{
    public class NavigateTo
    {
        public static void LogoScenario()
        {

        }
        public static void AboutUsScenario()
        {
            Menu menu = new Menu();
            menu.AboutUs.Click();
        }
        public static void OurExpertiseScenario()
        {
            Menu menu = new Menu();
            menu.OurExpertise.Click();
        }
        public static void InsightsScenario()
        {
            Menu menu = new Menu();
            menu.Insights.Click();
        }
        public static void ContactUsScenario()
        {
            Menu menu = new Menu();
            menu.ContactUs.Click();
        }
    }
}
