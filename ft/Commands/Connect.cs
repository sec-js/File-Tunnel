﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ft.Commands
{
    public class Connect : Command
    {
        public const byte COMMAND_ID = 10;
        public override byte CommandId => COMMAND_ID;

        public int ConnectionId { get; protected set; }

        public Connect() { }

        public Connect(int connectionId)
        {
            ConnectionId = connectionId;
        }

        protected override void Serialize(BinaryWriter writer)
        {
            writer.Write(ConnectionId);
        }

        protected override void Deserialize(BinaryReader reader)
        {
            ConnectionId = reader.ReadInt32();
        }
    }
}
