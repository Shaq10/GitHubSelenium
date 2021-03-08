using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace POMGit
{
    public class SeleniumDriverConfig
    {
		//Property for the driver for later use
		public IWebDriver Driver { get; set; }

		//Constructor that calls a method to set up the driver depending on the type of browser we want
		public SeleniumDriverConfig(string driver, int pageLaodsInSecs, int implicitWaitInSecs)
		{
			//Method that set ups the driver. We can pass in the driver type
			DriverSetUp(driver, pageLaodsInSecs, implicitWaitInSecs);
		}


		//This method will trigger another method that set the driver configuration depending on the browswer type
		public void DriverSetUp(string driverName, int pageLaodsInSecs, int implicitWaitInSecs)
		{
			if (driverName.ToLower() == "chrome")
			{
				//This method create the new driver instanec that we can use in our testing
				SetChromeDriver();
				//Method will set the config of the driver (pageload time and implicit wait)
				SetDriverConfiguration(pageLaodsInSecs, implicitWaitInSecs);
			}

			else if (driverName.ToLower() == "firefox")
			{
				//This method create the new driver instanec that we can use in our testing
				SetFirefoxDriver();
				//Method will set the config of the driver (pageload time and implicit wait)
				SetDriverConfiguration(pageLaodsInSecs, implicitWaitInSecs);
			}
		}


		public void SetFirefoxDriver()
		{
			Driver = new FirefoxDriver();
		}

		public void SetChromeDriver()
		{
			Driver = new ChromeDriver();
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("headless");
		}

		public void SetDriverConfiguration(int pageLoadsInSecs, int implicitWaitInSecs)
		{

			//Time driver will wait for page to load
			Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadsInSecs);
			//Time driver waits for element before the test fails
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);

		}
	}
}
