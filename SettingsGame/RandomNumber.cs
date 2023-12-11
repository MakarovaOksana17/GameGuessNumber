using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.SettingsGame
{
    public class RandomNumber: IRandom
    {

        private RangeNumber _range = new RangeNumber();

        public RandomNumber(string start, string end)
        {
            _range.setStartValue(start);
            _range.setEndValue(end);
        }

        public object getRandomValue()
        {
            if (_range.isDataCorrect())
            {
                return new Random().Next(Convert.ToInt32(_range.StartValue), Convert.ToInt32(_range.EndValue));
            }
            return new Random().Next(0,0);
        }
    }
}
