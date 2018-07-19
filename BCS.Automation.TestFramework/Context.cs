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
        private string windowsTestResultsPath = (Path.Combine(Environment.CurrentDirectory, "..\\..") + "\\TestResults").ToString();
        private string testDeploymentDirectory = string.Empty;

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

        private string CreateDeploymentDirectory()
        {
            string deploymentPath = string.Empty;
            string windowsDeploymentDirectory = windowsTestResultsPath + "\\AutomationTest_" 
                + Environment.UserName + "_" + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");

            if (!Directory.Exists(windowsDeploymentDirectory))
            {
                Directory.CreateDirectory(windowsDeploymentDirectory);
                deploymentPath = windowsDeploymentDirectory;
            }

            return deploymentPath;
        }
    }
}
