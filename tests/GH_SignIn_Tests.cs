using NUnit.Framework;
using System.Threading;

namespace POMGit
{
    public class GH_SignIn_Tests
    {
        public GH_Website GH_Website { get; } = new GH_Website("Chrome");

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIClickTheLogo_ThenIShouldLandOnTheHomePage() {
            GH_Website.GH_SignIn.VisitSignInPage();
            GH_Website.GH_SignIn.LogoPress();
            Assert.That(GH_Website.GH_SignIn.GetPageTitle(), Does.Contain("GitHub: Where the world builds software"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIClickTheCreateAnAccountLink_ThenIShouldLandOnTheSignUpPage()
        {
            GH_Website.GH_SignIn.VisitSignInPage();
            GH_Website.GH_SignIn.CreatePress();
            Assert.That(GH_Website.GH_SignIn.GetPageTitle(), Does.Contain("Join GitHub"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIClickTheForgotPasswordLink_ThenIShouldLandOnThePasswordResetPage()
        {
            GH_Website.GH_SignIn.VisitSignInPage();
            GH_Website.GH_SignIn.ForgotPasswordPress();
            Assert.That(GH_Website.GH_SignIn.GetPageTitle(), Does.Contain("Forgot your password?"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIEnterTheWrongPasswordAndClickSignInButton_ThenErrorMessageIsDisplayed()
        {
            GH_Website.GH_SignIn.VisitSignInPage();
            GH_Website.GH_SignIn.InputLogin("Shaq10");
            GH_Website.GH_SignIn.InputPassword("wrongpassword");
            GH_Website.GH_SignIn.SignInButton();
            Thread.Sleep(3000);
            Assert.That(GH_Website.GH_SignIn.GetAddy(), Is.EqualTo("https://github.com/session"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            GH_Website.SeleniumDriver.Quit();
            GH_Website.SeleniumDriver.Dispose();
        }
    }
}
