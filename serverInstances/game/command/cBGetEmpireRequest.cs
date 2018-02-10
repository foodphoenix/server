﻿using SuperSocket.SocketBase.Command;

using Libraries.packages.game;
using Libraries.enums;
using Libraries.player;
using Libraries.logger;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BGetEmpireRequest : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBGetEmpireRequest Request = new PacketBGetEmpireRequest(p.Content);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + Request);

            Player Player = s.GetPlayer();

            PacketBGetEmpireResponse ResponseContent = new PacketBGetEmpireResponse(Request.Xuid, Player.Empire.ToXml);

            Logger.Debug(p.Key + "::ExecuteCommand - Execute command: " + ResponseContent);

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BGetEmpireResponse, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
