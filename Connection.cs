using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Netchange_2._0
{
    class Connection
    {
        public StreamReader read;
        public StreamWriter write;

        public Connection(int port)
        {

        }

        public Connection(StreamReader read, StreamWriter write)
        {
            this.read = read;
            this.write = write;
        }
    }
}
