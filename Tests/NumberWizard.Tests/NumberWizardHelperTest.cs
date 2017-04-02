using NumberWizard.Engine.Helper;
using NUnit.Framework;
using Shouldly;

namespace NumberWizard.Tests
{
    public class NumberWizardHelperTest
    {
        [TestCase(1, 1000, 500)]
        [TestCase(1, 10, 5)]
        [TestCase(30, 60, 45)]
        [TestCase(100, 50, 75)]
        public void FindMid_VaryingMaxMin_GetMidValue(int max, int min, int expected)
        {
            WizardEngineHelper.FindMid(max, min).ShouldBe(expected);
        }
    }
}
