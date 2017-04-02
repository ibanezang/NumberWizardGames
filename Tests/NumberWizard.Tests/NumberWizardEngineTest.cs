using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberWizard.Engine;
using NUnit.Framework;
using Shouldly;

namespace NumberWizard.Tests
{
    public class NumberWizardEngineTest
    {
        [TestCase(0, 1000, 500)]
        [TestCase(0, 1000, 200)]
        [TestCase(0, 1000, 600)]
        [TestCase(0, 1000, 0)]
        [TestCase(0, 1000, 1000)]
        [TestCase(1, 5001, 1)]
        [TestCase(1, 5001, 5001)]
        public void NextGuessedNumber_GameSimulation_FindInLessThan30Guesses(int min, int max, int expectedNumber)
        {
            var engine = new NumberWizardEngine(min, max);
            var attemptCount = 0;
            while (true)
            {
                attemptCount++;
                attemptCount.ShouldBeLessThan(30);
                if (engine.GuessedNumber == expectedNumber)
                {
                    break;
                }
                if(engine.GuessedNumber > expectedNumber)
                {
                    engine.NextGuessedNumber(GuessedStatus.Lower);
                }
                if(engine.GuessedNumber < expectedNumber)
                {
                    engine.NextGuessedNumber(GuessedStatus.Higher);
                }
            }
        }
    }
}
