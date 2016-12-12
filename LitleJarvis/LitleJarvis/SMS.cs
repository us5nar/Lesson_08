using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitleJarvis
{
    class SMS : Command
    {
        string caption = "SMS sender";
        string usage = "commmand should contain words Jarvis, send SMS to Sarah:Blah blah blah.";

        private string message;
        private string addressee;
        public override void Action()
        {
            throw new NotImplementedException();
        }

        public override bool CheckInCommand()
        {
            
            //throw new NotImplementedException();
            return false;
        }
    }
}
