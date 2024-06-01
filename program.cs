using System;
using Oxide.Plugins;

namespace Oxide.Plugin {
    [Info("Tickrate meter", "Artem Shumilov a.k.a Herosh1", "0.1")]   
    class program : RustPlugin {
        [ChatCommand("tickrate")]

        void cmdChatRoll (BasePlayer player) {
            player.ChatMessage("Текущий тикрейт сервера: " + player.serverTickRate);
        }
    }
}