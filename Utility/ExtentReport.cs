using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;

namespace SpecFlowAviva.Utility
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        public static ExtentSparkReporter _sparkReporter;
        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults");

        public static void ExtentReportInit()
        {
            _sparkReporter = new ExtentSparkReporter(testResultPath + "\\index.html");
            _sparkReporter.Config.ReportName = "Automation Aviva Status Report";
            _sparkReporter.Config.DocumentTitle = "Status Report";
            _sparkReporter.Config.Theme = Theme.Standard;
            
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_sparkReporter);
            _extentReports.AddSystemInfo("Application", "Aviva");
            _extentReports.AddSystemInfo("Browser", "Chrome");
            _extentReports.AddSystemInfo("OS", "Windows");
        }


        public static void ExtetentReportTearDown() 
        {
            _extentReports.Flush();
        }

        public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContex)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenShotLocation = Path.Combine(testResultPath, scenarioContex.ScenarioInfo.Title + ".png");
            screenshot.SaveAsFile(screenShotLocation);
            return screenShotLocation;
        }
    }
}
