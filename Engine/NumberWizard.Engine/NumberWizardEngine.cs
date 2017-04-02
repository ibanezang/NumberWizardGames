using NumberWizard.Engine.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWizard.Engine
{
    public class NumberWizardEngine
    {
        private int _minNumber;
        private int _maxNumber;
        private int _guessedNumber;
        public int GuessedNumber { get { return _guessedNumber; } }

        public NumberWizardEngine(int minNumber, int maxNumber)
        {
            _minNumber = minNumber;
            _maxNumber = maxNumber + 1;
            _guessedNumber = WizardEngineHelper.FindMid(minNumber, maxNumber);
        }

        public int NextGuessedNumber(GuessedStatus status)
        {
            if(status == GuessedStatus.Lower)
            {
                Lower();
            }
            if(status == GuessedStatus.Higher)
            {
                Higher();
            }
            return GuessedNumber;
        }

        private void Lower()
        {
            _maxNumber = GuessedNumber;
            _guessedNumber = WizardEngineHelper.FindMid(_minNumber, _maxNumber);
        }
        private void Higher()
        {
            _minNumber = GuessedNumber;
            _guessedNumber = WizardEngineHelper.FindMid(_minNumber, _maxNumber);
        }
    }

    public enum GuessedStatus
    {
        Lower, Higher
    }
}
