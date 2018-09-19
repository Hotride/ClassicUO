﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassicUO.Network;

using static ClassicUO.Network.NetClient;

namespace ClassicUO.Game
{
    public static class GameActions
    {
        public static void DoubleClick(Serial serial)     
            => Socket.Send(new PDoubleClickRequest(serial));
        

        public static void SingleClick(Serial serial)
            => Socket.Send(new PClickRequest(serial));

        public static void Say(string message, ushort hue = 0x17, MessageType type = MessageType.Regular, MessageFont font = MessageFont.Normal)
            => Socket.Send(new PUnicodeSpeechRequest(message, type, font, hue, "ENU"));

        public static void SayParty(string message)
            => Socket.Send(new PPartyMessage(message, World.Player));
    }
}