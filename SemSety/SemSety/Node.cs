using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemSety
{
    class Node
    {
        public string Name;
        List<Connection> incomingConnections;
        List<Connection> outConnections;
        public Node(String Name)
        {
            incomingConnections = new List<Connection>();
            outConnections = new List<Connection>();
            this.Name = Name;
        }

        public void AddIncomingConnection(string NameConnection, Node Signal)
        {
            incomingConnections.Add(new Connection(NameConnection,Signal));
        }

        public void AddOutConnection(string NameConnection, Node Signal)
        {
            outConnections.Add(new Connection(NameConnection, Signal));
        }

        public bool SearchIncomingConnection(string Name, Node Signal)
        {
            string getName = null;
            for(int i = 0; i < incomingConnections.Count; i++)
            {
                if ((incomingConnections[i].Name == Name) &&(incomingConnections[i].Signal == Signal)) return true;
            }
            return false;
        }
        public bool SearchOutConnection(string Name, Node Signal)
        {
            string getName = null;
            for (int i = 0; i < outConnections.Count; i++)
            {
                if (outConnections[i].Name == Name && (outConnections[i].Signal == Signal)) return true;
            }
            return false;
        }
    }
}
