using BCS.Automation.TestFramework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BCS.Automation.Tests.StepDefinitions
{
    public class BaseSteps
    {
        private static Context context;

        public Context Context
        {
            get
            {
                if(context == null)
                {
                    context = new Context();
                }
                return context;
            }
            set { context = value; }
        }

        private string screenshotFileName;

        public string ScreenshotFileName
        {
            get
            {
                screenshotFileName = Context.TestDeploymentDirectory + "\\" + Context.TestScenario + ".jpeg";

                return screenshotFileName;
            }
            set { screenshotFileName = value; }
        }
        
        public void BaseInitialize()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
            Context.TestName = FeatureContext.Current.FeatureInfo.Title;

            if (!Context.TestScenario.Contains(ScenarioContext.Current.ScenarioInfo.Title) && !(Context.RowNumber > 1))
            {
                Context.RowNumber = 1;
            }

            Context.TestScenario = ScenarioContext.Current.ScenarioInfo.Title + string.Format("[{0}]", Context.RowNumber);
        }
    }
}
