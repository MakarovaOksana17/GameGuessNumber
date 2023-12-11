using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Player
{
    public interface IPlayer
    {
        void setValue(string value);
        object getValue();
    }
}
