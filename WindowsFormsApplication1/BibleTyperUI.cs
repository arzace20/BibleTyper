using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BibleTyper
{
    public partial class BibleTyperUI : Form
    {
        
        public BibleTyperUI()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            BibleTyper BT = new BibleTyper();
            string NewBookName = "";
            BT.Login.MNG("arzace20", "02r7real");
            BT.Setup.driver.SwitchTo().Frame(1);
            BT.BibleName = BibleSelectComboBox.Text;
            if (BT.BibleName.Equals("한글성경"))
            {
                BT.Setup.driver.FindElement(By.XPath("//td[2]/p/a/img")).Click();
            }
            else if (BT.BibleName.Equals("쉬운성경"))
            {
                BT.Setup.driver.FindElement(By.XPath("//td[3]/p/a/img")).Click();
            }
            else if (BT.BibleName.Equals("영어성경"))
            {
                BT.Setup.driver.FindElement(By.XPath("//td[4]/p/a/img")).Click();
            }
            BT.pause(6000);
            BT.Setup.driver.SwitchTo().DefaultContent();
            if (ResumeRadio.Checked)
            {
                BT.MainPage.ClickOnFirstTypeItem();
            }
            else if (StartRadio.Checked)
            {
                BT.MainPage.ClickOnBook(BookSelectBox.Text);
            }
            BT.TypePage.TypeAll();
            BT.Setup.driver.SwitchTo().DefaultContent();
            int newIndex = BT.General.BookIndex(BT.InitialBookName);
            for (int i = newIndex + 1; i < 67; i++)
            {
                BT.pause(5000);
                BT.Setup.driver.SwitchTo().DefaultContent();
                try
                {
                    BT.Setup.driver.SwitchTo().Frame(1);
                    NewBookName = BT.Setup.driver.FindElement(By.XPath("//option[@value='" + i + "']")).Text.Split(' ')[1];
                }
                catch (Exception)
                {
                    BT.Setup.driver.SwitchTo().DefaultContent();
                    NewBookName = BT.Setup.driver.FindElement(By.XPath("//option[@value='" + i + "']")).Text.Split(' ')[1];
                }
                NewBookName = NewBookName.Trim();
                BT.Setup.driver.SwitchTo().DefaultContent();
                BT.MainPage.ClickOnBook(NewBookName);
                BT.TypePage.TypeAll();
            }
        }

        private void StartRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (StartRadio.Checked)
            {
                ResumeRadio.Checked = false;
            }
            else
            {
                ResumeRadio.Checked = true;
            }
        }

        private void ResumeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ResumeRadio.Checked)
            {
                StartRadio.Checked = false;
            }
            else
            {
                StartRadio.Checked = true;
            }
        }
    }
}
