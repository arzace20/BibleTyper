using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;


namespace BibleTyper
{
    public class Setup
    {
        public IWebDriver driver;
        public String baseUrl;
        public int TimeOut;

        private StringBuilder verificationErrors = new StringBuilder();

        //Setup constructor sets up Firefox profile
        public Setup()
        {
            baseUrl = "http://ctmbible.net/";
            //Everytime a script is run, a temporary firefox profile will be created under c:/Users/YOURNAME/AppData/Local/Temp. Clear out this folder at the end of each day
            FirefoxProfile FProfile = new FirefoxProfile(@"C:\Users\Kevin JH Lee\AppData\Roaming\Mozilla\Firefox\Profiles\4hatoi28.default");
            FProfile.AcceptUntrustedCertificates = true;
            //FProfile.SetPreference("webdriver.load.strategy", "unstable");
            /* string firebugPath = @"C:\Users\Kevin JH Lee\Documents\Software\firebug@software.joehewitt.com.xpi";
             string firePathPath = @"C:\Users\Kevin JH Lee\Documents\Software\fireXPath@pierre.tholence.com.xpi";
             //For development purposes, firebug extension is loaded
             string firebugPath = @"C:\Users\klee\AppData\Roaming\Mozilla\Firefox\Profiles\w4k1hqwk.default\extensions\firebug@software.joehewitt.com.xpi";
             string firePathPath = @"C:\Users\klee\AppData\Roaming\Mozilla\Firefox\Profiles\w4k1hqwk.default\extensions\FireXPath@pierre.tholence.com.xpi";*/
            /*if (File.Exists(firebugPath))
            {
                FProfile.AddExtension(firebugPath);
            }
            if (File.Exists(firePathPath))
            {
                FProfile.AddExtension(firePathPath);
            }*/
            
            driver = new FirefoxDriver(FProfile);
            driver.Manage().Window.Maximize();

            //driver.Navigate().GoToUrl(baseUrl + "/LogOn/LogOn?ReturnUrl=%2f");
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void teardown()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            //Assert.AreEqual("", verificationErrors.ToString());
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
