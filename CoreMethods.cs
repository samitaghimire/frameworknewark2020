using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NewarkProject_2020
{
    class CoreMethods
    {
        //login
        //entertextbox
        //clickbutton

        //register
        // EntertextBox
        //dropdownselect
        public static void dropdownselect(IWebDriver driver, String controltype)
        {
            if (controltype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id("radius_dd"))).SelectByIndex(4);
            }
            if (controltype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id("Gender"))).SelectByIndex(2);
            }
            if (controltype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id("Race"))).SelectByIndex(2);
            }
            if (controltype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id("Education"))).SelectByIndex(9);
            }
        }
        //checkboxelect
        public static void checkBoxSelect(IWebDriver driver, String controlType, String ControlID)
			{
				if (controlType.Equals("Id"))
					driver.FindElement(By.Id(ControlID)).Click();
				if (controlType.Equals("xpath"))
					driver.FindElement(By.XPath(ControlID)).Click();

			}
	    
	     
	    //textbox enter
	    public static void textboxenter(IWebDriver driver, String ControlType, String ControlID, String Value)
        {
            if (ControlType.Equals("Id"))
                driver.FindElement(By.Id(ControlID)).SendKeys(Value);
            if (ControlType.Equals("Name"))
                driver.FindElement(By.Name(ControlID)).SendKeys(Value);
        }
	
	    //buttonclick
        public static void buttonclick(IWebDriver driver, String ControlType, String ControlID)
        {
            if (ControlType.Equals("Id"))
                driver.FindElement(By.Id(ControlID)).Click();
            if (ControlType.Equals("xPath"))
                driver.FindElement(By.XPath(ControlID)).Click();


        }

        //logout
        //clickbutton
    }
}
