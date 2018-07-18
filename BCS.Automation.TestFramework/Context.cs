using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Automation.TestFramework
{
    public class Context
    {
        private string windowsTestResultsPath = (Path.Combine(Environment.CurrentDirectory, @"..\..") + "\\TestResults").ToString();
        private string testDeploymentDirectory = string.Empty;
        private string testResultsDirectory = string.Empty;

        public string TestName { get; set; } = string.Empty;
        public string TestScenario { get; set; } = string.Empty;
        public int RowNumber { get; set; } = 1;

        public string TestDeploymentDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(testDeploymentDirectory))
                {
                    testDeploymentDirectory = CreateDeploymentDirectory();
                }
                return testDeploymentDirectory;
            }

            set { testDeploymentDirectory = value; }
        }

        public string TestResultsDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(testResultsDirectory))
                {
                    testResultsDirectory = CreateTestResultsDirectory();
                }
                return testResultsDirectory;
            }

            set { testResultsDirectory = value; }
        }

        private string CreateTestResultsDirectory()
        {
            string testResultsPath = string.Empty;

            if (!Directory.Exists(windowsTestResultsPath))
            {
                Directory.CreateDirectory(windowsTestResultsPath);
                testResultsPath = windowsTestResultsPath;
            }

            return testResultsPath;
        }

        private string CreateDeploymentDirectory()
        {
            string deploymentPath = string.Empty;
            string windowsDeploymentDirectory = windowsTestResultsPath + "\\AutomationTest_" + Environment.UserName + "_" + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");

            if (!Directory.Exists(windowsDeploymentDirectory))
            {
                Directory.CreateDirectory(windowsDeploymentDirectory);
                deploymentPath = windowsDeploymentDirectory;
            }

            return deploymentPath;
        }
    }
}
