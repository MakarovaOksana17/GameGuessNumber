using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.SettingsGame
{
    public class NumberAttempt : ICorrectly
    {
         int _countAttempt;
        public  int countAttempt { get => _countAttempt; }
        
        public NumberAttempt(string countAttept)
        {
            _countAttempt = Convert.ToInt32(countAttept);
        }

        public bool isDataCorrect()
        {
            return _countAttempt > 0 ? true : false;
        }

        public bool isAttemptOver(int countItteration)
        {
            return countItteration == _countAttempt ? true: false;
        }
    }
}
