using System;
using Oxide.Plugins;

namespace Oxide.Plugin
{   class program : RustPlugin {
        [ChatCommand("roll")]

        void cmdChatRoll (BasePlayer player) {
            player.ChatMessage("Текущий тикрейт сервера: " + player.serverTickRate);
        }
    }
}