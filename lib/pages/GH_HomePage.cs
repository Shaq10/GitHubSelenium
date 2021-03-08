using OpenQA.Selenium;

namespace POMGit
{
    public class GH_HomePage
    {
        private IWebDriver _seleniumDriver;

        private string HomePageUrl = AppConfigReader.BaseUrl;

        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));
        private IWebElement _signUpLink => _seleniumDriver.FindElement(By.LinkText("Sign up"));
        private IWebElement _signUpGreenButton => _seleniumDriver.FindElement(By.ClassName("btn-mktg-fluid"));

        private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("user_email"));
        private IWebElement _searchBar => _seleniumDriver.FindElement(By.ClassName("header-search-input"));
        private IWebElement _searchDropdown => _seleniumDriver.FindElement(By.Id("jump-to-suggestion-search-global"));

        public GH_HomePage(IWebDriver seleniumDriver) {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitHomePage() {
            _seleniumDriver.Navigate().GoToUrl(HomePageUrl);
        }

        public void VisitSignInPage() {
            _signInLink.Click();
        }

        public void VisitSignUpPage()
        {
            _signUpLink.Click();
        }

        public void InputEmail(string email)
        {
            _emailField.SendKeys(email);
        }

        public void SignUpButtonPress() {
            _signUpGreenButton.Click();
        }

        public void InputSearch(string search) {
            _searchBar.SendKeys(search);
        }

        public string GetDropdownText() {
            return _searchDropdown.Text;
        }

        public void DropdownPress() {
            _searchDropdown.Click();
        }


        public string GetPageTitle()
        {
            return _seleniumDriver.Title;
        }

        public string GetAddy()
        {
            return _seleniumDriver.Url;
        }
    }
}
