using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NavarraTrialWithSelenium.Models;
using NavarraTrialWithSelenium.PageObjects;
using System;
using FluentAssertions;

namespace NavarraTrialWithSelenium
{
    [TestClass]
    public class SeleniumTest
    {
        private IWebDriver driver;
        private const string userName = "alvaro.igartua";
        private const string password = "SElenium77";
        private const string navarraUrl = "https://grup5web.firebaseapp.com/properties/properties.html?region=Navarra";
        private const int mostExpensiveHouseLocation = 0;
        private const string commentToSumit = "I'm delighted to claim this house as my new home.";
        private const string expectedResult = "1 interesados";
        private RegisteringPageObject registeringPage;
        private LogInPageObject loginPage;
        private MappingPageObject mappingPage;
        private SelectedHousePageObject selectedHousePage;
        private RegisterForm registerFormInputs;
        private LoginForms loginFormInputs;

        [TestInitialize]
        public void SetUp()
        {
            this.driver = new ChromeDriver(@"C:\chromedriver_win32");
            this.registeringPage = new RegisteringPageObject(this.driver);
            this.loginPage = new LogInPageObject(this.driver);
            this.mappingPage = new MappingPageObject(this.driver, navarraUrl);
            this.selectedHousePage = new SelectedHousePageObject(this.driver);
            this.registerFormInputs = new RegisterForm()
            {
                Name = "Alvaro",
                LastName = "Igartua Aizpiri",
                DNI = "79077256J",
                Birthday = "01-09-1996",
                Address = "C/Autonomía 54",
                City = "Bilbao",
                ZipCode = "48012",
                Country = "Spain",
                Phone = "622343875",
                Email = "alvaroigartua@gmail.com",
                UserName = userName,
                Password = password,
                VerifiedPassword = password
            };

            this.loginFormInputs = new LoginForms()
            {
                UserName = userName,
                Password = password
            };
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            this.NavigateToUrl();

            this.RegisterAnAccount(this.registerFormInputs);

            this.LoginWithCreatedAccount(this.loginFormInputs);

            this.FilterToNavarraMostExpensiveSales();

            this.SubmitACommentInTheSelectedHouse();

            this.mappingPage.VerifyChosenHouseAttributes(mostExpensiveHouseLocation, expectedResult).Should().BeTrue();

        }

        private void NavigateToUrl()
        {
            this.driver.Navigate().GoToUrl("https://grup5web.firebaseapp.com");
            var registerButtonElement = this.driver.FindElement(By.LinkText("Registrarse"));
            registerButtonElement.Click();
        }

        private void RegisterAnAccount(RegisterForm registerForm)
        {
            this.registeringPage.UserRegistration(registerForm);
            this.registeringPage.ClickRegistering();
        }

        private void LoginWithCreatedAccount(LoginForms loginForms)
        {
            this.loginPage.UserLogin(loginForms);
            this.loginPage.ClickRegistering();
        }

        private void FilterToNavarraMostExpensiveSales()
        {
            this.mappingPage.FilteringSet();
            this.mappingPage.ChooseAndSelectAHouse(mostExpensiveHouseLocation);
        }

        private void SubmitACommentInTheSelectedHouse()
        {
            this.selectedHousePage.SubmitAComment(commentToSumit);
        }
    }
}
