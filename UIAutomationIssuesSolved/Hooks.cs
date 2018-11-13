using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Threading;

namespace UIAutomationIssuesSolved
{
    public class Hooks
    {
        IWebDriver driver = new ChromeDriver();
        string GoogleURL = "https://www.google.co.uk/";
        string wikiURL = "https://en.wikipedia.org/wiki/Main_Page";
        //string textCopied;
        string trimmedText;

        By GoogleSearchBox = By.Id("lst-ib");
        By GooggleSearchBtn = By.XPath("//input[contains(@value,'Google Search')]");
        By TargetTextToCopy = By.XPath("(//a[@href='/wiki/Wikipedia'][contains(.,'Wikipedia')])[1]");


        public void StartWikipedia()
        {
            driver.Navigate().GoToUrl(wikiURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        public string CopyTheTextToCopy()
        {
            IWebElement element1 = driver.FindElement(TargetTextToCopy);
            element1.SendKeys(Keys.Control + "a");
            string text = element1.Text;

            char[] CharactersToTrim = { 'W', 'a' };
            return trimmedText = text.Trim(CharactersToTrim);
        }

        public void CloseChrome()
        {
            driver.Quit();
            driver.Dispose();
        }

        public void ExecuteGoogleSearch()
        {
            driver.Navigate().GoToUrl(GoogleURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(GoogleSearchBox).SendKeys(trimmedText);
        }

        //public string AssertResult()
        //{
        //    IWebElement resultTextCopy = driver.FindElement(GoogleSearchBox);
        //    resultTextCopy.SendKeys(Keys.Control + "a");
        //    string resultText = resultTextCopy.Text;
        //    return resultText;
        //}
        
        public void ClickGoogleSearchButtonToSearch()
        {
            driver.FindElement(GooggleSearchBtn).Click();
        }
        
    }
}
