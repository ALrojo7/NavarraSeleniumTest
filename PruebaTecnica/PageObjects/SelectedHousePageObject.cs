using OpenQA.Selenium;
using System.Threading;

namespace NavarraTrialWithSelenium.PageObjects
{
    internal class SelectedHousePageObject
    {
        IWebDriver driver;

        private const string url = "https://grup5web.firebaseapp.com/properties/properties.html?region=Navarra";
        By commentField = By.Id("comments");
        By submitComment = By.XPath("//input[@value='Enviar']");

        

        internal SelectedHousePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        private void NavigateBack()
        {
            this.driver.Navigate().GoToUrl(url);
        }
        internal void SubmitAComment(string comment)
        {
            Thread.Sleep(2000);
            this.driver.FindElement(this.commentField).SendKeys(comment);
            this.driver.FindElement(this.submitComment).Click();
            this.NavigateBack();
        }


    }
}
