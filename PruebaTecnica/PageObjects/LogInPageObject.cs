using NavarraTrialWithSelenium.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NavarraTrialWithSelenium.PageObjects
{
    internal class LogInPageObject
    {
        IWebDriver driver;
        By inputUserName = By.Id("username");
        By inputPassword = By.Id("password");
        By loginBtn = By.XPath("//input[@value = 'Conectarse']");

        internal LogInPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        private void SetLoginUserName(string strUserName)
        {
            this.driver.FindElement(this.inputUserName).Click();
            this.driver.FindElement(this.inputUserName).SendKeys(strUserName);

        }

        private void SetLoginPassword(string strPassword)
        {
            this.driver.FindElement(this.inputPassword).Click();
            this.driver.FindElement(this.inputPassword).SendKeys(strPassword);

        }

        internal void ClickRegistering()
        {
            this.driver.FindElement(loginBtn).Click();
        }

        internal void UserLogin(LoginForms loginInputs)
        {
            Thread.Sleep(2000);
            this.SetLoginUserName(loginInputs.UserName);
            this.SetLoginPassword(loginInputs.Password);
        }
    }
}
