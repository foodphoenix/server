﻿using SuperSocket.SocketBase.Command;

using Libraries.enums;
using Libraries.player;
using Libraries.logger;
using Libraries.packages.game;

using Libraries.helpers.package;


namespace Game.Command
{

    public class BRequestAndIncrementScenarioIdPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="p">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            PacketBRequestAndIncrementScenarioIdPacket Request = new PacketBRequestAndIncrementScenarioIdPacket(p.Content);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {Request}");

            Player ObjPlayer = s.Player;

            int Scenarioid = ObjPlayer.Empire.CurrentCharacter.Nextscenarioid + Request.Increment;

            ObjPlayer.Empire.CurrentCharacter.Nextscenarioid = Scenarioid;

            PacketBResponseScenarioIdPacket ResponseContent = new PacketBResponseScenarioIdPacket(Scenarioid);

            Logger.Debug($"{p.Key}::ExecuteCommand - Execute command: {ResponseContent}");

            byte[] Response = ResponseContent.ToByteArray();

            Package Package = new Package(p.HeaderXuid, p.HeaderField20, p.HeaderServiceId, p.HeaderField22, PacketTypes.BResponseScenarioIdPacket, p.HeaderRequestId, Response);

            byte[] ToSend = Package.ToByteArray();

            s.Send(ToSend, 0, ToSend.Length);

        }

    }

}
