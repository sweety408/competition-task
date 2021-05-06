using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : GlobalDefinitions

        {

            [Test]
            public void Test()
            {

                // page object for login page
                SignIn signinObj = new SignIn();
                signinObj.LoginSteps();

            }
            [Test]
            public void Signup()
            {
                // page object for signup page
                SignUp signupObj = new SignUp();
                signupObj.Register();
            }
            [Test]
            public void ShareSkill()
            {
                // page object for share skill page
                ShareSkill shareskillObj = new ShareSkill();
                shareskillObj.EnterShareSkill();

            }
            [Test]
            public void Listings()
            {
                // Page object for manage listings page
                ManageListings ListingsObj = new ManageListings();
                ListingsObj.Listings();

            }
            [TearDown]
            public void FinalSteps()
            {
                driver.Close();

            }












        }
    }
}