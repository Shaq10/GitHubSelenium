using OpenQA.Selenium;

namespace POMGit
{
    public class GH_SignIn
    {
        private IWebDriver _seleniumDriver;
        private string _signInPageURL = AppConfigReader.SignInPageUrl;
        private IWebElement _homeLink => _seleniumDriver.FindElement(By.ClassName("header-logo"));
        private IWebElement _createAccountLink => _seleniumDriver.FindElement(By.LinkText("Create an account"));
        private IWebElement _forgotPasswordLink => _seleniumDriver.FindElement(By.LinkText("Forgot password?"));
        private IWebElement _loginField => _seleniumDriver.FindElement(By.Id("login_field"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _signInButton => _seleniumDriver.FindElement(By.ClassName("btn"));
        

        public GH_SignIn(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitSignInPage()
        {
            _seleniumDriver.Navigate().GoToUrl(_signInPageURL);
        }

        public void LogoPress() {
            _homeLink.Click();
        }

        public void CreatePress()
        {
            _createAccountLink.Click();
        }

        public void ForgotPasswordPress() {
            _forgotPasswordLink.Click();
        }

        public void InputLogin(string login) {
            _loginField.SendKeys(login);
        }

        public void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void SignInButton() {
            _signInButton.Click();
        }

        public string GetPageTitle()
        {
            return _seleniumDriver.Title;
        }

        public string GetAddy() {
            return _seleniumDriver.Url;
        }
    }
}
