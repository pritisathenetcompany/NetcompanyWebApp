using NetcompanyWebApp.Helper;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NetcompanyWebApp.Pages
{
    public class LoginPage :BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
         private  IWebElement userName ;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Login')]")]
        private IWebElement loginButton;

        public void navigatetologinpage()
        {
            driver.Navigate().GoToUrl("C:/Users/prsat/source/repos/nc-demo-webapp/index.html");
        }
        public void EnterUserId(string name)
        {
            userName.SendKeys(name);
        }
        public void EnterUserPassword(string name)
        {
            password.SendKeys(name);
        }
        public void SubmitLogin()
        {
            loginButton.Click();
        }

        public void login()
        {
            navigatetologinpage();
            EnterUserId("admin");
            EnterUserPassword("admin_password");
            SubmitLogin();
        }
    }
}