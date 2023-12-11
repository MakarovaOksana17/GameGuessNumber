using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Player
{
    public class PlayerNumber : IPlayer
    {
        int _responceValue;     

        public PlayerNumber(string responceValue)
        {
            setValue(responceValue);
        }

        public object getValue()
        {
            return _responceValue;
        }

        public void setValue(string value)
        {
            _responceValue = Convert.ToInt32(value);
        }
    }
}
