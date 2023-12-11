using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.SettingsGame
{
    public abstract class InitialValues
    {
        public string StartValue { get; set; }
        public string EndValue { get; set; } 
        public  abstract void setStartValue(string start);
        public  abstract void setEndValue(string end);          
    }
}
