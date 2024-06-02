using System;
using Oxide.Plugins;

namespace Oxide.Plugin {
    [Info("Tickrate meter", "Artem Shumilov a.k.a Herosh1", "0.4")]
    [Description("Плагин для отображения тикрейта сервера. В приоретете для админов серверов, если понадобится тикрейт сервера")]   
    class program : RustPlugin {

        [ChatCommand("tickrate")]

        void cmdChatTickrate (BasePlayer player) {
            player.ChatMessage("Текущий тикрейт сервера: " + player.serverTickRate);
        }
    }
}