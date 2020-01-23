using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LABInventory
{
    /// <summary>
    /// This class represents inventory for LAB servers
    /// </summary>
    class Server
    {
        #region Properties
        public string ServerName { get; set; }

        public string SerialNumber { get; set; }

        public int ProductID { get; set; }

        public string ServerOS { get; set; }
        
        public decimal IPAddress { get; set; }

        public decimal OSVersion { get; set; }
        #endregion

        #region Methods

        public string Asset(string Add)
        {
            ServerName = Add;
            return ServerName;
        }
        #endregion
    }
}
