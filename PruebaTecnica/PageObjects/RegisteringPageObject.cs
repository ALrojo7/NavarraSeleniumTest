using NavarraTrialWithSelenium.Models;
using OpenQA.Selenium;
using System.Threading;

namespace NavarraTrialWithSelenium.PageObjects
{
    internal class RegisteringPageObject
    {

        IWebDriver driver;
        By registeringName = By.Id("name");
        By registeringLastName = By.Id("lastname");
        By registeringDNI = By.Id("dni");
        By registeringBirthday = By.Id("birthdate");
        By registeringAddress = By.Id("address");
        By registeringCity = By.Id("city");
        By registeringZipCode = By.Id("zipcode");
        By registeringCountry = By.Id("country");
        By registeringPhone = By.Id("phone");
        By registeringEmail = By.Id("email");
        By registeringUserName = By.Id("username");
        By registeringPassword = By.Id("password");
        By registeringVerifyPassword = By.Id("verifyPassword");
        By registeringFormSubmit = By.XPath("//input[@value='Registrarme']");

        internal RegisteringPageObject(IWebDriver driver)
        {

            this.driver = driver;
        }

        private void SetRegisterName(string strName)
        {
            this.driver.FindElement(this.registeringName).Click();
            this.driver.FindElement(this.registeringName).SendKeys(strName);
        }

        private void SetRegisterLastName(string strLastName)
        {
            this.driver.FindElement(this.registeringLastName).Click();
            this.driver.FindElement(this.registeringLastName).SendKeys(strLastName);
        }
        private void SetRegisterDNI(string strDNI)
        {
            this.driver.FindElement(this.registeringDNI).Click();
            this.driver.FindElement(this.registeringDNI).SendKeys(strDNI);
        }
        private void SetRegisterBirthDate(string strBirthDate)
        {
            this.driver.FindElement(this.registeringBirthday).Click();
            this.driver.FindElement(this.registeringBirthday).SendKeys(strBirthDate);
        }
        private void SetRegisterAddress(string strAddress)
        {
            this.driver.FindElement(this.registeringAddress).Click();
            this.driver.FindElement(this.registeringAddress).SendKeys(strAddress);
        }
        private void SetRegisterCity(string strCity)
        {
            this.driver.FindElement(this.registeringCity).Click();
            this.driver.FindElement(this.registeringCity).SendKeys(strCity);
        }
        private void SetRegisterZipCode(string strZipCode)
        {
            this.driver.FindElement(this.registeringZipCode).Click();
            this.driver.FindElement(this.registeringZipCode).SendKeys(strZipCode);
        }
        private void SetRegisterCountry(string strcountry)
        {
            this.driver.FindElement(this.registeringCountry).Click();
            this.driver.FindElement(this.registeringCountry).SendKeys(strcountry);
        }
        private void SetRegisterPhone(string strPhone)
        {
            this.driver.FindElement(this.registeringPhone).SendKeys(strPhone);
        }
        private void SetRegisterEmail(string strEmail)
        {
            this.driver.FindElement(this.registeringEmail).Click();
            this.driver.FindElement(this.registeringEmail).SendKeys(strEmail);
        }
        private void SetRegisterUserName(string strUserName)
        {
            this.driver.FindElement(this.registeringUserName).Click();
            this.driver.FindElement(this.registeringUserName).SendKeys(strUserName);
        }
        private void SetRegisterPassword(string strPassword)
        {
            this.driver.FindElement(this.registeringPassword).Click();
            this.driver.FindElement(this.registeringPassword).SendKeys(strPassword);
        }
        private void SetRegisterPasswordVerification(string strVerifiedPassword)
        {
            this.driver.FindElement(this.registeringVerifyPassword).Click();
            this.driver.FindElement(this.registeringVerifyPassword).SendKeys(strVerifiedPassword);
        }
        internal void ClickRegistering()
        {
            this.driver.FindElement(registeringFormSubmit).Click();
        }

        internal void UserRegistration(RegisterForm registeringInputs)
        {
            Thread.Sleep(2000);
            this.SetRegisterName(registeringInputs.Name);
            this.SetRegisterLastName(registeringInputs.LastName);
            this.SetRegisterDNI(registeringInputs.DNI);
            this.SetRegisterBirthDate(registeringInputs.Birthday);
            this.SetRegisterAddress(registeringInputs.Address);
            this.SetRegisterCity(registeringInputs.City);
            this.SetRegisterZipCode(registeringInputs.ZipCode);
            this.SetRegisterCountry(registeringInputs.Country);
            this.SetRegisterPhone(registeringInputs.Phone);
            this.SetRegisterEmail(registeringInputs.Email);
            this.SetRegisterUserName(registeringInputs.UserName);
            this.SetRegisterPassword(registeringInputs.Password);
            this.SetRegisterPasswordVerification(registeringInputs.VerifiedPassword);
        }

    }
}
