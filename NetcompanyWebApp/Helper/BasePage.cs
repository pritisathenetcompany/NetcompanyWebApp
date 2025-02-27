using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NetcompanyWebApp.Helper
{
    public class BasePage
    {
        public static IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }   

        public IWebElement WaitForElementByXPath(string xpath, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            return wait.Until(driver => driver.FindElement(By.XPath(xpath)));
        }

        public IWebElement WaitForElementById(string id, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            return wait.Until(driver => driver.FindElement(By.Id(id)));
        }
    }
}