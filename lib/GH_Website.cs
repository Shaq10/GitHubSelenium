using OpenQA.Selenium;

namespace POMGit
{
    public class GH_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public GH_HomePage GH_HomePage { get; internal set; }
        public GH_SignIn GH_SignIn { get; internal set; }
        public GH_SignUp GH_SignUp { get; internal set; }

        public GH_Website(string driverName, int pageLoadWaitInSecs = 15, int implicitWaitInSecs = 15) {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            GH_HomePage = new GH_HomePage(SeleniumDriver);
            GH_SignIn = new GH_SignIn(SeleniumDriver);
            GH_SignUp = new GH_SignUp(SeleniumDriver);
        }
        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
