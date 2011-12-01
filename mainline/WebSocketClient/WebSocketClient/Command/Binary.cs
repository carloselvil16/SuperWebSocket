﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.ClientEngine;

namespace SuperWebSocket.WebSocketClient.Command
{
    public class Binary : WebSocketCommandBase
    {
        public override void ExecuteCommand(WebSocket session, WebSocketCommandInfo commandInfo)
        {
            throw new NotImplementedException();
        }

        public override string Name
        {
            get { return OpCode.Binary.ToString(); }
        }
    }
}