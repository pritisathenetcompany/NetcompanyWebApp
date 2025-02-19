using OpenQA.Selenium;
using NetcompanyWebApp.Helper;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace NetcompanyWebApp.Pages
{
    public class DashboardPage:BasePage
    {

       // IWebElement header => FindElementByXPath("//*[contains(text(), 'Dashboard')]");

        IWebElement header => WaitForElementByXPath("//*[contains(text(), 'Dashboard')]", TimeSpan.FromSeconds(10));


        public DashboardPage(IWebDriver driver) : base(driver)
        {

        }

        // public void VerifyHeader(string expectedHeader)
        // {
        //     Assert.AreEqual(expectedHeader, header,$"Incorrect Header");
        // }

        public void VerifyHeader(string expectedHeader)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => header.Displayed);  // Ensure the element is visible

            Assert.AreEqual(expectedHeader, header.Text, "Incorrect Header");
        }





    }
}
