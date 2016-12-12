using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitleJarvis
{
    abstract class Command:ICommand
    {
        public string InputString { protected set; get; }
        public string Caption { protected set; get; }
        public string Usage { protected set; get; }
        public string Pattern { protected set; get; }           
        abstract public void Action();
        abstract public bool CheckInCommand();
        public Command()
        {
            Pattern = "";
            Caption = "";
            Usage = "";           
        }
    }
}

