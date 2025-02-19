using System;

using Reqnroll;
using NetcompanyWebApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NetcompanyWebApp.StepDefinitions
{
    [Binding]
    public class UserLoginStepDefinitions
    {
        private readonly IWebDriver _driver;
        private LoginPage _loginPage;
        private DashboardPage _dashboardPage;


        public UserLoginStepDefinitions()
       {
            _driver = new ChromeDriver();
            _loginPage = new LoginPage(_driver);
            _dashboardPage = new DashboardPage(_driver);

        }

        [Given("User navigates to the loginpage")]
        public void GivenUserNavigatesToTheLoginpage()
        {
            _driver.Navigate().GoToUrl("C:/Users/prsat/source/repos/nc-demo-webapp/index.html");
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

        

    }
}
