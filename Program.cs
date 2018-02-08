using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netchange_2._0
{
    class Program
    {
        #region Variables
        static int myPort;
        static int[] routingTable;

        #endregion

        /// <summary>
        /// Main method, called upon at the start of the program
        /// </summary>
        /// <param name="args">given parameters</param>
        static void Main(string[] args)
        {
            Initiate(args);
        }

        /// <summary>
        /// Initiates this node
        /// </summary>
        /// <param name="args"></param>
        static void Initiate(string[] args)
        {
            //TEMP
            if (args.Length == 0)
                return;
            //ENDTEMP

            // assign this nodes port number
            myPort = int.Parse(args[0]);

            // assign the direct neighbours to the routing table
            foreach (string s in args)
            {
                int port = int.Parse(s);
                routingTable[port % 100] = port;
            }
        }
    }
}
