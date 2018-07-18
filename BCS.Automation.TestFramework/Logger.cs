using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Automation.TestFramework
{
    public static class Logger
    {
        public static void TakeScreenshot(string fileName)
        {
            ((ITakesScreenshot)Browser.WebDriver).GetScreenshot()
                .SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
        }
        
    }
}
