using NUnit.Framework;
using System.Threading;

namespace POMGit
{
    public class GH_SignUp_Tests
    {
        public GH_Website GH_Website { get; } = new GH_Website("Chrome");

        [Test]
        public void GivenIAmOnTheSignUpPage_WhenIClickTheLogo_ThenIShouldLandOnTheHomePage()
        {
            GH_Website.GH_SignUp.VisitSignUpPage();
            GH_Website.GH_SignUp.LogoPress();
            Assert.That(GH_Website.GH_SignIn.GetPageTitle(), Does.Contain("GitHub: Where the world builds software"));
        }

        [Test]
        public void GivenIAmOnTheSignUpPage_WhenIClickTheSignInLink_ThenIShouldLandOnTheSignInPage()
        {
            GH_Website.GH_SignUp.VisitSignUpPage();
            GH_Website.GH_SignUp.VisitSignInPage();
            Assert.That(GH_Website.GH_SignUp.GetPageTitle(), Does.Contain("Sign in to GitHub"));
        }

        [Test]
        public void GivenIAmOnSignInPage_WhenIEnterValidCredentials_ThenInstructionsGoGreen()
        {
            GH_Website.GH_SignUp.VisitSignUpPage();
            GH_Website.GH_SignUp.InputUser("Eng71Username");
            GH_Website.GH_SignUp.InputEmail("thisemailhasnotbeentakenyetshaq@gmail.com");
            GH_Website.GH_SignUp.InputPassword("poskbhjdjsa90T");
            Assert.That(GH_Website.GH_SignUp.InputValid(), Does.Contain("least 8"));     
        }

        [Test]
        public void GivenIAmOnSignInPage_WhenIEnterInvalidPassword_ThenInstructionsGoRed()
        {
            GH_Website.GH_SignUp.VisitSignUpPage();
            GH_Website.GH_SignUp.InputUser("Eng71Username");
            GH_Website.GH_SignUp.InputEmail("thisemailhasnotbeentakenyetshaq@gmail.com");
            GH_Website.GH_SignUp.InputPassword("posk");
            Assert.That(GH_Website.GH_SignUp.InputInvalid(), Does.Contain("least 15"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            GH_Website.SeleniumDriver.Quit();
            GH_Website.SeleniumDriver.Dispose();
        }
    }
}
