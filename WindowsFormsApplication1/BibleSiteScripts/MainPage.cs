using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BibleTyper
{
    public class MainPage
    {
        private BibleTyper BT;
        private Boolean BookClickFailed = false;
        public MainPage(BibleTyper BT)
        {
            this.BT = BT;
        }

        public void ClickOnFirstTypeItem()
        {
            BT.Setup.driver.SwitchTo().Frame(1);
            string iBN = BT.Setup.driver.FindElement(By.XPath("//td/a/font[1]")).Text.Split('(')[0];
            BT.InitialBookName = iBN.Trim();
            BT.Setup.driver.FindElement(By.XPath("//td/a/font[1]")).Click();
            BT.pause(10000);
        }

        public void ClickOnBook(string BookName)
        {
            BT.Setup.driver.SwitchTo().Frame(1);
            BT.InitialBookName = BookName;
            try
            {
                BT.Setup.driver.FindElement(By.XPath("//option[@value='" + BT.General.BookIndex(BookName) + "']")).Click();
            }
            catch (Exception)
            {
                /*BookClickFailed = true;
                BT.Setup.driver.SwitchTo().DefaultContent();
                BT.Setup.driver.FindElement(By.XPath("//input[@type='button' and @value='메인으로(저장)']")).Click();*/
            }            
            BT.pause(6000);
            /*if (BookClickFailed)
            {
                BookClickFailed = false;
                ClickOnBook(BookName);
            }*/
        }
    }
}
