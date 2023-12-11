using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.SettingsGame
{
    public class RandomValue
    {
        IRandom _random;

        public RandomValue(IRandom random )
        {
            _random = random;
        }

        public object Rand()
        {
            return _random.getRandomValue();
        }
    }
}
