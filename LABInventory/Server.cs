using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LABInventory
{
    class Server
    {
        public string ServerName { get; set; }

        public string SerialNumber { get; set; }

        public int ProductID { get; set; }

        public string ServerOS { get; set; }
        
        public decimal IPAddress { get; set; }

        public decimal OSVersion { get; set; }


    }
}
