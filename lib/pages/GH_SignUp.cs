using OpenQA.Selenium;

namespace POMGit
{
    public class GH_SignUp
    {
        private IWebDriver _seleniumDriver;
        private string _signUpPageURL = AppConfigReader.SignUpPageUrl;

        private IWebElement _homeLink => _seleniumDriver.FindElement(By.ClassName("mr-4"));
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));
        private IWebElement _userField => _seleniumDriver.FindElement(By.Id("user_login"));
        private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("user_email"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("user_password"));
        private IWebElement _success => _seleniumDriver.FindElement(By.ClassName("text-green"));
        private IWebElement _failure => _seleniumDriver.FindElement(By.ClassName("text-red"));

        public GH_SignUp(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitSignUpPage()
        {
            _seleniumDriver.Navigate().GoToUrl(_signUpPageURL);
        }

        public void VisitSignInPage()
        {
            _signInLink.Click();
        }

        public void LogoPress()
        {
            _homeLink.Click();
        }

        public void InputUser(string username)
        {
            _userField.SendKeys(username);
        }

        public void InputEmail(string email) {
            _emailField.SendKeys(email);
        }

        public void InputPassword(string password) {
            _passwordField.SendKeys(password);
        }

        public string GetPageTitle()
        {
            return _seleniumDriver.Title;
        }

        public string InputValid() {
            return _success.Text;
        }

        public string InputInvalid()
        {
            return _failure.Text;
        }

        public string GetEmail() {
            return _emailField.Text;
        }
    }
}
