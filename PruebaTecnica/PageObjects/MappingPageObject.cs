using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NavarraTrialWithSelenium.PageObjects
{
    internal class MappingPageObject
    {
        IWebDriver driver;
        private string Url;
        By filterLocation = By.Id("filter");
        By listOfHouses = By.Id("propertiesList");
        
        internal MappingPageObject(IWebDriver driver, string url)
        {
            this.driver = driver;
            this.Url = url;
        }

        private void FilterToTheMostExpensive()
        {
            this.driver.FindElement(this.filterLocation).Click();
            this.driver.FindElement(this.filterLocation).SendKeys("los más caros");
            this.driver.FindElement(this.filterLocation).Click();
        }
        private void NavigateToNavarraUrl(string url)
        {
            this.driver.Navigate().GoToUrl(url);
        }

        internal void ChooseAndSelectAHouse(int optionPosition)
        {  
            IList<IWebElement> elementsInThePropertiesList = this.driver.FindElements(this.listOfHouses);
            var selectedHouseInTheList = elementsInThePropertiesList.ElementAt(optionPosition);

            By chosenHouse = By.Id(selectedHouseInTheList.GetAttribute("Id"));

            this.driver.FindElement(chosenHouse).Click();

        }

        internal bool VerifyChosenHouseAttributes(int optionPosition, string expectedAttributeValue)
        {
            this.FilterToTheMostExpensive();

            IList<IWebElement> elementsInThePropertiesList = this.driver.FindElements(this.listOfHouses);
            var selectedHouseInTheList = elementsInThePropertiesList.ElementAt(optionPosition);
            bool AttributeConditionIsOk = false;
            if (selectedHouseInTheList.Text.Contains(expectedAttributeValue)) AttributeConditionIsOk = true;

            return AttributeConditionIsOk;
        }
        internal void FilteringSet()
        {
            Thread.Sleep(2000);
            this.NavigateToNavarraUrl(this.Url);
            this.FilterToTheMostExpensive();
        }   

    }
}
