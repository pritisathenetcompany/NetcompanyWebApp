using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Reqnroll.BoDi;
using WebDriverManager.DriverConfigs.Impl;
[Binding]
public class TestSetup
{
    private IWebDriver _driver;
    private readonly IObjectContainer _objectContainer;

    public TestSetup(IObjectContainer objectContainer)
    {
        _objectContainer = objectContainer;
    }

    [BeforeScenario]
    public void InitializeBrowser(ScenarioContext scenarioContext)
    {
        Environment.SetEnvironmentVariable("browser", "chrome");

        Console.WriteLine("Initializing browser for scenario: " + scenarioContext.ScenarioInfo.Title);

        string browser = Environment.GetEnvironmentVariable("browser");

        if (string.IsNullOrEmpty(browser))
        {
            throw new ArgumentException("No browser specified! Please set the 'browser' environment variable.");
        }

        switch (browser.ToLower())
        {
            case "chrome":
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
              
                _driver = new ChromeDriver( );
                break;           
            default:
                throw new ArgumentException("Unsupported browser: " + browser);
        }

        _driver.Manage().Window.Maximize();
        _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
    }

    [AfterScenario]
    public void TearDown(ScenarioContext scenarioContext)
    {
        if (_driver != null)
        {
            _driver.Quit();
        }
    }
}