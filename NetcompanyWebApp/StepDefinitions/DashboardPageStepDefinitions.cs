using System;
using NetcompanyWebApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace NetcompanyWebApp.StepDefinitions
{
    [Binding]
    public class DashboardPageStepDefinitions
    {
       private readonly IWebDriver _driver;
        private DashboardPage _dashboardPage;

        public DashboardPageStepDefinitions()
        {
           // _driver = new ChromeDriver();
            _dashboardPage = new DashboardPage(_driver);
        } 


        [Given("User navigates to the dashboard")]
        public void GivenUserNavigatesToTheDashboard()
        {
            throw new PendingStepException();
        }

        [When("Selects a country {string}")]
        public void WhenSelectsACountry(string uK)
        {
            throw new PendingStepException();
        }

        [Then("Displays {string}")]
        public void ThenDisplays(string uK)
        {
            throw new PendingStepException();
        }

        [Then("Navigates to {string} page")]
        public void ThenNavigatesToPage(string dashboard)
        {
            _dashboardPage.VerifyHeader(dashboard);
        }


    }
}
