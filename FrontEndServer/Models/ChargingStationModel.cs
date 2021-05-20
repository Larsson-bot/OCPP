using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndServer.Models
{
    public class ChargingStationModel
    {
            public int Id { get; set; }
            public string SerialNumber { get; set; }
            public string Ip { get; set; }
            public string Port { get; set; }
            public string SocketId { get; set; }
            public bool Available { get; set; }
    }
}
