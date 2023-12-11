using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Game
{
    public interface ICalculation
    {
        bool isMinValue();
        bool isMaxValue();
        bool isEqual();
    }
}
