using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitleJarvis
{
    abstract class Command:ICommand
    {
        public string Caption;
        public string Usage;
        abstract public void Action(string UserInput);
        abstract public bool CheckInCommand(string UserInput);
    }
}
