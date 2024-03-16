using OpenQA.Selenium;
using SpecFlowSeleniumProject.Drivers;

namespace SpecFlowSeleniumProject.Pages
{
    public class LoginPage
    {
        private readonly IDriverHelper _driverhelper;

        public LoginPage(IDriverHelper driverhelper)
        {
            this._driverhelper = driverhelper;
        }

        IWebElement txtUserName => _driverhelper.Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => _driverhelper.Driver.FindElement(By.Id("Password"));

        IWebElement btnLogin => _driverhelper.Driver.FindElement(By.XPath("//input[@value ='Log in']"));

        IWebElement lnkLogoff => _driverhelper.Driver.FindElement(By.LinkText("Log off"));


        public void EnterUserNamePassword(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            
        }

        public void Login() => btnLogin.Submit();

        public bool LogoffExits() => lnkLogoff.Displayed;


    }
}
