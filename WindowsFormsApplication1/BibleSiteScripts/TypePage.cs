using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BibleTyper
{
    public class TypePage
    {
        private BibleTyper BT;
        private IWebElement CurrentLine;
        private Boolean ErrorThrown = false;
        public TypePage(BibleTyper BT)
        {
            this.BT = BT;
        }

        public void TypeAll()
        {
            IWebElement iFrame = BT.Setup.driver.FindElement(By.XPath("//iframe"));
            BT.Setup.driver.SwitchTo().Frame(iFrame);
            int formIndex = 2;
            string LineToCopy = "";
            int LineCount = 0;
            if (BT.BibleName.Equals("한글성경"))
            {
                LineCount = Convert.ToInt32(BT.Setup.driver.FindElement(By.CssSelector("body > form:nth-last-child(4)")).GetAttribute("name").Split('f')[1]);
            }
            else if (BT.BibleName.Equals("쉬운성경"))
            {
                LineCount = Convert.ToInt32(BT.Setup.driver.FindElement(By.CssSelector("body > form:nth-last-child(5)")).GetAttribute("name").Split('f')[1]);
            }
            for (int i = 0; i <= LineCount * 4; i = i + 4)
            {
                try
                {
                    CurrentLine = BT.Setup.driver.FindElement(By.CssSelector("body > form:nth-child(" + (formIndex + i) + ")"));
                    LineToCopy = CurrentLine.FindElement(By.CssSelector("input:first-child")).GetAttribute("value");
                }
                catch (Exception)
                {
                    ErrorThrown = true;
                    try
                    {
                        while (BT.Setup.driver.SwitchTo().ActiveElement().Equals(BT.Setup.driver.SwitchTo().Alert()))
                        {
                            BT.Setup.driver.SwitchTo().Alert().Accept();
                        }
                    }
                    catch (Exception) { }
                    BT.Setup.driver.SwitchTo().DefaultContent();
                    BT.Setup.driver.FindElement(By.XPath("//input[@type='button' and @value='메인으로(저장)']")).Click();
                    break;
                }
                try
                {
                    IWebElement InputLine = CurrentLine.FindElement(By.XPath("./input[@type='TEXT']"));
                    InputLine.Clear();
                    InputLine.SendKeys(LineToCopy);
                    InputLine.SendKeys(Keys.Enter);
                    BT.pause(500);
                }
                catch (Exception) { }
            }
            BT.pause(6000);
            if (!BT.Setup.driver.Title.Contains("컴퓨터전문인선교회"))
            {
                TypeAll();
            }
            if (ErrorThrown)
            {
                ErrorThrown = false;
                BT.MainPage.ClickOnFirstTypeItem();
                TypeAll();
            }
        }
    }
}
