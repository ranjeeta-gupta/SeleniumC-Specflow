using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowSeleniumProject.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private IDriverHelper _driverHelper;

        public Hooks1(IDriverHelper driverHelper)
        {
            this._driverHelper = driverHelper;
        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            _driverHelper.Driver = new ChromeDriver(chromeOptions);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver .Quit();
        }
    }
}