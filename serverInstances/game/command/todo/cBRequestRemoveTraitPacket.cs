﻿using SuperSocket.SocketBase.Command;

using Libraries.helpers.package;
using Libraries.packages.game;
using Libraries.enums;
using Libraries.logger;


namespace Game.Command
{

    public class BRequestRemoveTraitPacket : CommandBase<Session, Package>
    {

        /// <summary>
        /// Executes the command and sends response.
        /// </summary>
        /// <param name="s">The session.</param>
        /// <param name="i">The package info.</param>
        public override void ExecuteCommand(Session s, Package p)
        {

            var Request = new Libraries.packages.todo.PacketBRequestRemoveTraitPacket(p.Content);

            Logger.DebugFormat("BRequestRemoveTraitPacket::ExecuteCommand - Execute command: {0}", Request);





        }

    }

}
