using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
       
        public ManageListings()
        {

            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement View { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement Edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement ClickActionsButton { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

            // click on managelistings link
            ManageListingsLink.Click();

            // click on Eye icon on manage listings page
            View.Click();

            //click on edit icon on manage listing page
            Edit.Click();
            Thread.Sleep(2000);

            // click on action button
            ClickActionsButton.Click();



        }
    }
}
