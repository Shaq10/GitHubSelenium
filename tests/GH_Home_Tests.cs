using NUnit.Framework;
using System.Threading;

namespace POMGit
{
    public class GH_Home_Tests
    {
        public GH_Website GH_Website { get; } = new GH_Website("Chrome");

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSigninLink_ThenIShouldLandOnTheSigninPage()
        {
            GH_Website.GH_HomePage.VisitHomePage();
            GH_Website.GH_HomePage.VisitSignInPage();
            Assert.That(GH_Website.GH_HomePage.GetPageTitle(), Does.Contain("Sign in to GitHub"));
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignupLinkIn_ThenIShouldLandOnTheSignupPage()
        {
            GH_Website.GH_HomePage.VisitHomePage();
            GH_Website.GH_HomePage.VisitSignUpPage();
            Assert.That(GH_Website.GH_HomePage.GetPageTitle(), Does.Contain("Join GitHub"));
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheGreenSignupButton_ThenIShouldLandOnTheSignupPage()
        {
            GH_Website.GH_HomePage.VisitHomePage();
            GH_Website.GH_HomePage.SignUpButtonPress();
            Assert.That(GH_Website.GH_HomePage.GetPageTitle(), Does.Contain("Join GitHub"));
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenISearchForATerm_ThenTheDropDownShouldContainTerm() {
            GH_Website.GH_HomePage.VisitHomePage();
            GH_Website.GH_HomePage.InputSearch("Shaq10");
            Assert.That(GH_Website.GH_HomePage.GetDropdownText(), Does.Contain("Shaq10"));
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenISearchForATermAndClickTheDropDown_ThenIShouldLandOnTheResultsPage()
        {
            GH_Website.GH_HomePage.VisitHomePage();
            GH_Website.GH_HomePage.InputSearch("Shaq10");
            GH_Website.GH_HomePage.DropdownPress();
            Assert.That(GH_Website.GH_HomePage.GetAddy(), Is.EqualTo("https://github.com/search?q=Shaq10"));
        }

        //[Test]
        //public void GivenIAmOnTheHomePage_WhenIEnterAValidEmailAndClickTheSignUpButton_ThenIAmTakenToTheSignUpPageAndTheEmailIsPresent() {
        //    GH_Website.GH_HomePage.VisitHomePage();
        //    GH_Website.GH_HomePage.InputEmail("Eng71email2@gmail.com");
        //    GH_Website.GH_HomePage.SignUpButtonPress();
        //    Assert.That(GH_Website.GH_SignUp.GetEmail(), Does.Contain("Eng71email2@gmail.com"));
        //}

        [OneTimeTearDown]
        public void CleanUp()
        {
            GH_Website.SeleniumDriver.Quit();
            GH_Website.SeleniumDriver.Dispose();
        }
    }
}
