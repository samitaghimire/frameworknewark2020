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

        //logout
        //clickbutton
    }
}
