using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewarkProject_2020
{
    class FeatureMethods
    {
        public static IWebDriver driver = new ChromeDriver();

        public static void login()
        {
            driver.Url = @"http://107.180.79.11:8080/";
            CoreMethods.buttonclick(driver, "Id", Control_Id.login_Click);
            CoreMethods.textboxenter(driver, "Id", Control_Id.username, input.usernameValue);
            CoreMethods.textboxenter(driver, "Name", Control_Id.password, input.passvalue);
            CoreMethods.buttonclick(driver, "XPath", Control_Id.loginbutton);

        }
    }
}
