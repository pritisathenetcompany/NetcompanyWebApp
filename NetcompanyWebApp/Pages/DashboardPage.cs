using OpenQA.Selenium;
using NetcompanyWebApp.Helper;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace NetcompanyWebApp.Pages
{
    public class DashboardPage : BasePage
    {

        public DashboardPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(driver, this);
        }
        IWebElement header => WaitForElementByXPath("//h2[contains(text(), 'Dashboard')]", TimeSpan.FromSeconds(10));

        IWebElement selectCountryText => WaitForElementById("countries", TimeSpan.FromSeconds(10));
        IWebElement countryText => WaitForElementByXPath("//p[contains(text(), 'Country selected')]", TimeSpan.FromSeconds(10));

        IWebElement checkbox => WaitForElementById("checkbox", TimeSpan.FromSeconds(10));
        IWebElement checkboxTextDisplayed => WaitForElementById("checkboxConfirm", TimeSpan.FromSeconds(10));

        IWebElement radioButton1 => WaitForElementById("radio1", TimeSpan.FromSeconds(10));
        IWebElement radioButton2 => WaitForElementById("radio2", TimeSpan.FromSeconds(10));
        IWebElement radioTestMessage => WaitForElementById("radioConfirm", TimeSpan.FromSeconds(10));


        public string getHeader()
        {
            string actualHeader;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => header.Displayed);

            actualHeader = header.Text;
            return actualHeader;
        }

        public string selectCountry(string country)
        {
            SelectElement select = new SelectElement(selectCountryText);             
            select.SelectByText(country);
            return select.SelectedOption.Text;
        }

        public String displayedcountrytext()
        {
            string actualcountrydisplayed;
            actualcountrydisplayed = countryText.Text;
            string[] parts = actualcountrydisplayed.Split(new string[] {"is: " }, StringSplitOptions.None);
            string result = parts[1];
            return result;
        }

        public String displayActualText()
        {
            string actualcountrydisplayed;
            actualcountrydisplayed = countryText.Text;            
            return actualcountrydisplayed;
        }

        public bool checkboxselected()
        { 
            checkbox.Click();
            return true;
        }

        public string checkboxmessage()
        {
            string message;            
            message = checkboxTextDisplayed.Text;
            return message;
        }

        public bool checkboxnotselected()
        {
            if (!checkbox.Selected)
            {
                return true;
            }
            else
                return false;
        }
    }
}