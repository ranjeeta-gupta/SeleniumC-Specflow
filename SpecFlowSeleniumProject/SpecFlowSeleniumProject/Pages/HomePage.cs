using OpenQA.Selenium;
using SpecFlowSeleniumProject.Drivers;

namespace SpecFlowSeleniumProject.Pages
{
    public class HomePage 
    {
        private readonly IDriverHelper  _driverhelper;
        public HomePage(IDriverHelper driverhelper)
        {
            _driverhelper = driverhelper;
        }

        IWebElement lnkHome => _driverhelper.Driver.FindElement(By.LinkText("Home"));
        IWebElement lnkAbout => _driverhelper.Driver.FindElement(By.LinkText("About"));

        IWebElement lnkEmployeeList => _driverhelper.Driver.FindElement(By.LinkText("Employee List"));

        IWebElement lnkRegister => _driverhelper.Driver.FindElement(By.Id("registerLink"));

        IWebElement lnkLogin => _driverhelper.Driver.FindElement(By.Id("loginLink"));

        public void ClickLogin() => lnkLogin.Click();







    }
}
