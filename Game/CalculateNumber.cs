using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessNumberGame.Player;
using GuessNumberGame.SettingsGame;

namespace GuessNumberGame.Game
{
    public class CalculateNumber : ICalculation
    {
        IPlayer _player;
        int _playerNumber;
        int _randomValue;

        public CalculateNumber(IPlayer player, int randomValue)
        {
            _player = player;
            _playerNumber = (int)_player.getValue();
            _randomValue = randomValue;
        }

        public bool isEqual()
        {
            return _playerNumber == _randomValue ? true : false;
        }

        public bool isMaxValue()
        {
            return _playerNumber < _randomValue ? true : false;
        }

        public bool isMinValue()
        {
            return _playerNumber > _randomValue ? true : false;
        }        
    }
}
