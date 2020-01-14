using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemSety
{
    class Connection
    {
        public string Name;
        public Node Signal;
        public Connection(string Name, Node Signal)
        {
            this.Name = Name;
            this.Signal = Signal;
        }
    }
}
