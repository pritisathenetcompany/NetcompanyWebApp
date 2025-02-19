using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NetcompanyWebApp.Helper
{
    
    public class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
           this.driver = driver;
        }

        public IWebElement FindElementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public IWebElement FindElementByName(string name)
        {
            return driver.FindElement(By.Name(name));
        }

        public IWebElement FindElementByXPath(string xpath)
        {
            return driver.FindElement(By.XPath(xpath));
        }

        public IWebElement FindElementByCssSelector(string cssSelector)
        {
            return driver.FindElement(By.CssSelector(cssSelector));
        }

        public IWebElement FindElementByLinkText(string linkText)
        {
            return driver.FindElement(By.LinkText(linkText));
        }

        public IWebElement FindElementByPartialLinkText(string partialLinkText)
        {
            return driver.FindElement(By.PartialLinkText(partialLinkText));
        }

        public IReadOnlyCollection<IWebElement> FindElementsByClassName(string className)
        {
            return driver.FindElements(By.ClassName(className));
        }

        public IWebElement FindElementByTagName(string tagName)
        {
            return driver.FindElement(By.TagName(tagName));
        }

        public IWebElement WaitForElementByCssSelector(string cssSelector, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            return wait.Until(driver => driver.FindElement(By.CssSelector(cssSelector)));
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

        public IReadOnlyCollection<IWebElement> FindElementsByXPath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }

        public void SwitchToIframe(string iframeId)
        {
            driver.SwitchTo().Frame(iframeId);
        }

        public void SwitchBackToMainContent()
        {
            driver.SwitchTo().DefaultContent();
        }
    }

}