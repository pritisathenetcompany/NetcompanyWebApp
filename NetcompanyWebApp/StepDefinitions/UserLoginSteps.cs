using System;
using Reqnroll;
using NetcompanyWebApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NetcompanyWebApp.Helper;

namespace NetcompanyWebApp.StepDefinitions
{
    [Binding]
    public class UserLoginSteps:BasePage
    {
        private LoginPage _loginPage;
        public UserLoginSteps(IWebDriver driver) : base(new ChromeDriver())
        {
            _loginPage = new LoginPage(driver);
        }

        [Given("User navigates to the loginpage")]
        public void GivenUserNavigatesToTheLoginpage()
        {
            _loginPage.navigatetologinpage();
        }

        [When("Enters Username {string} and Password {string}")]
        public void WhenEntersUsernameAndPassword(string userName,string password)
        {
            _loginPage.EnterUserId(userName);
            _loginPage.EnterUserPassword(password);
            
        }

        [When("Clicks on Login button")]
        public void WhenClickOnLoginButton()
        {
            _loginPage.SubmitLogin();
        }

        [Given("User navigates to the dashboard")]
        public void GivenUserNavigatesToTheDashboard()
        {
            _loginPage.login();
        }
    }
}