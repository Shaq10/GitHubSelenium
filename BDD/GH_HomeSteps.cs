using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace POMGit
{
    [Binding]
    public class GH_HomeSteps
    {
        public GH_Website GH_Website { get; } = new GH_Website("Chrome");

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            GH_Website.GH_HomePage.VisitHomePage();
        }

        [When(@"I click the sign in link")]
        public void WhenIClickTheSignInLink()
        {
            GH_Website.GH_HomePage.VisitSignInPage();
            Thread.Sleep(1000);
        }

        [Then(@"I should land on the page which contains the title ""(.*)""")]
        public void ThenIShouldLandOnThePageWhichContainsTheTitle(string expected)
        {
            Assert.That(GH_Website.GH_HomePage.GetPageTitle(), Does.Contain(expected));
        }

        [When(@"I click the sign up link")]
        public void WhenIClickTheSignUpLink()
        {
            GH_Website.GH_HomePage.VisitSignUpPage();
            Thread.Sleep(1000);
        }

        [When(@"I click the sign up button")]
        public void WhenIClickTheSignUpButton()
        {
            GH_Website.GH_HomePage.SignUpButtonPress();
        }

        [When(@"I enter the term (.*) in the search bar")]
        public void WhenIEnterTheTermInTheSearchBar(string input)
        {
            GH_Website.GH_HomePage.InputSearch(input);
        }

        [Then(@"The DropDown should contain term (.*)")]
        public void ThenTheDropDownShouldContainTerm(string expected)
        {
            GH_Website.GH_HomePage.GetDropdownText();
        }

        [When(@"I search for the term '(.*)'")]
        public void WhenISearchForTheTerm(string term)
        {
            GH_Website.GH_HomePage.InputSearch(term);
        }

        [When(@"Click the drop down")]
        public void WhenClickTheDropDown()
        {
            GH_Website.GH_HomePage.DropdownPress();
        }

        [Then(@"I should land on the results page with the URL ""(.*)""")]
        public void ThenIShouldLandOnTheResultsPageWithTheURL(string expected)
        {
            Assert.That(GH_Website.GH_HomePage.GetAddy(), Is.EqualTo(expected));
        }


        [AfterScenario]
        public void CleanUp()
        {
            GH_Website.SeleniumDriver.Quit();
            GH_Website.SeleniumDriver.Dispose();
        }

    }
}
