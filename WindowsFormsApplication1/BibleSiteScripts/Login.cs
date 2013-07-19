using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace BibleTyper
{
    public class Login
    {
        private BibleTyper BT;

        public Login(BibleTyper BT)
        {
            this.BT = BT;            
        }

        public void MNG(string UserName, string PassWord)
        {
            BT.Setup.driver.SwitchTo().Frame(1);
            BT.Setup.driver.FindElement(By.XPath("//input[@type='TEXT']")).Clear();
            BT.Setup.driver.FindElement(By.XPath("//input[@type='TEXT']")).SendKeys(UserName);
            BT.pause(1000);
            BT.Setup.driver.FindElement(By.XPath("//input[@type='PASSWORD']")).Clear();
            BT.Setup.driver.FindElement(By.XPath("//input[@type='PASSWORD']")).SendKeys(PassWord);
            BT.pause(1000);
            BT.Setup.driver.FindElement(By.XPath("//input[@type='IMAGE']")).Click();
            BT.pause(10000);
        }
    }
}
