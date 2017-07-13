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

        public static void searchByMiles()
        {
            driver.Url = "http://107.180.79.11:8080/";
            CoreMethods.dropdownselect(driver, "Id");
        }
    }
}
