using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsFramework.Pages
{
    class SignIn
    {
        
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            // click on sign in tab
            SignIntab.Click();

            //Enter Email Id
            Email.SendKeys("sweetypatelnz@gmail.com");

            //Enter password
            Password.SendKeys("Initial$1993");

            //click on login button
            LoginBtn.Click();
                

        }
    }
}