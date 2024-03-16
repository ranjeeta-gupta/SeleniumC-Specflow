using OpenQA.Selenium;
using SpecFlowSeleniumProject.Drivers;
using SpecFlowSeleniumProject.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSeleniumProject.StepDefinitions
{
    [Binding]
    public sealed class LoginDefinitions
    {
        private readonly IDriverHelper _driverhelper;
        private readonly HomePage _homePage;
        private readonly LoginPage _loginPage;

        public LoginDefinitions(IDriverHelper driverhelper)
        {
            _driverhelper = driverhelper;
            _homePage = new HomePage(driverhelper);
            _loginPage = new LoginPage(driverhelper);
        }



        [Given(@"I navigate to the Application")]
        public void GivenINavigateToTheApplication()
        {
            _driverhelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click on the Login link")]
        public void GivenIClickOnTheLoginLink()
        {
            _homePage.ClickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.EnterUserNamePassword((string)data.UserName,(string)data.Password);

        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            _loginPage.Login();
        }

        [Then(@"I should see User logged in the application")]
        public void ThenIShouldSeeUserLoggedInTheApplication()
        {
           _loginPage.LogoffExits().Should().BeTrue(); 
        }

    }
}
