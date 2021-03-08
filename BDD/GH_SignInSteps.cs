using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace POMGit
{
    [Binding]
    public class GH_SignInSteps
    {
        public GH_Website GH_Website { get; } = new GH_Website("Chrome");

        [Given(@"I am on the sign in")]
        public void GivenIAmOnTheSignIn()
        {
            GH_Website.GH_SignIn.VisitSignInPage();
        }
        
        [Given(@"I have entered the login '(.*)'")]
        public void GivenIHaveEnteredTheLogin(string login)
        {
            GH_Website.GH_SignIn.InputLogin(login);
        }
        
        [Given(@"I have entered the password '(.*)'")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            GH_Website.GH_SignIn.InputPassword(password);
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            GH_Website.GH_SignIn.SignInButton();
            Thread.Sleep(2000);
        }
        
        [Then(@"I should land on the page ""(.*)"" where an error message is displayed")]
        public void ThenIShouldLandOnThePageWhereAnErrorMessageIsDisplayed(string p0)
        {
            Assert.That(GH_Website.GH_SignIn.GetAddy(), Is.EqualTo("https://github.com/session"));
        }

        [When(@"I click the forgot password link")]
        public void WhenIClickTheForgotPasswordLink()
        {
            GH_Website.GH_SignIn.ForgotPasswordPress();
        }

        [Then(@"I end up on the page containing the title ""(.*)""")]
        public void ThenIEndUpOnThePageContainingTheTitle(string expected)
        {
            Assert.That(GH_Website.GH_SignIn.GetPageTitle(), Does.Contain(expected));
        }

        [AfterScenario]
        public void CleanUp()
        {
            GH_Website.SeleniumDriver.Quit();
            GH_Website.SeleniumDriver.Dispose();
        }

    }
}
