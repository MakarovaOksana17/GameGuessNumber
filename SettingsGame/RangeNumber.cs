using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.SettingsGame
{
    public class RangeNumber : InitialValues, ICorrectly
    {
        private int _numberStart;
        private int _numberEnd;
        public bool isDataCorrect()
        {
            return _numberStart < _numberEnd ? true : false;
        }
        
        public override void setEndValue(string end)
        {
            EndValue = end;
            _numberEnd = Convert.ToInt32(end);
        }

        public override void setStartValue(string start)
        {
           StartValue = start;
            _numberStart = Convert.ToInt32(start);
        }
    }
}
