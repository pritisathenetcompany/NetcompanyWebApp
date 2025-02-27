using NetcompanyWebApp.Helper;
using NetcompanyWebApp.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NetcompanyWebApp.StepDefinitions
{
    [Binding]
    public class DashboardPageSteps : BasePage
    {
        private DashboardPage _dashboardPage;
        string selectedAcualCountry;
        bool checkboxselected;
        bool checkboxdeselected;
        string actualMessage;

        public DashboardPageSteps(IWebDriver driver) : base(driver)
        {
            _dashboardPage = new DashboardPage(driver);
        }

        [When("Selects a country {string}")]
        public void WhenSelectsACountry(string country)
        {
            selectedAcualCountry = _dashboardPage.selectCountry(country);
        }

        [Then("Displays country {string} and correct {string}")]
        public void ThenDisplaysCountryAndCorrect(string country,string message)
        {
            string countryDisplayed = _dashboardPage.displayedcountrytext();
            string actualText = _dashboardPage.displayActualText();
            string expectedMessage = message + " " + country;
            Assert.That(selectedAcualCountry, Is.EqualTo(countryDisplayed), "Selected country is Incorrect");
            Assert.That(actualText, Is.EqualTo(expectedMessage), "Text is Incorrect");
        }

        [Then("Navigates to {string} page")]
        public void ThenNavigatesToPage(string dashboard)
        {
            Assert.That(_dashboardPage.getHeader(), Is.EqualTo(dashboard), "Incorrect Header");
        }

        [When("Selects a checkbox")]
        public void WhenSelectsACheckbox()
        {
            checkboxselected = _dashboardPage.checkboxselected();
            actualMessage = _dashboardPage.checkboxmessage();
        }

        [When("Deselects a checkbox")]
        public void WhenDeselectsACheckbox()
        {
            checkboxdeselected = _dashboardPage.checkboxnotselected();
            actualMessage = _dashboardPage.checkboxmessage();
        }

        [Then("Displays {string}")]
        public void ThenDisplays(string expectedMessage)
        {
            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "Incorrect message");           
        }
    }
}