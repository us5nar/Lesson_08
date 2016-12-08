using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitleJarvis
{
    abstract class Command:ICommand
    {
        public string InputString;
        public string Caption;
        public string Usage;
        //private string inptString;
        abstract public void Action();
        abstract public bool CheckInCommand();
    }
}
