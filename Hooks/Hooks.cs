using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestsharpAPI_Automation.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            TestContext.WriteLine("Before test run");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            TestContext.WriteLine("Before Scenario");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            TestContext.WriteLine("Before Context");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
          TestContext.WriteLine("After feature");
        }


        [AfterScenario]
        public void AfterScenario()
        {
            TestContext.WriteLine("After Scenario");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestContext.WriteLine("After test run");
        }
        
        
        
    }
}
