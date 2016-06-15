using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API.Collections;
using SDG.Unturned;
using a4834833.VotifierXP;

namespace fr34kyn01535.VotifierXP
{
    public class VotifierXP : RocketPlugin<VotifierXPConfiguration>
    {
        protected override void Load()
        {
            Logger.Log("VotifierXP has been Loaded! ");
        
            Votifier.Votifier.Instance.OnPlayerVoted += Instance_OnPlayerVoted;
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    { "votifierxp_player_has_voted","Thanks for voting on {0}, you have received {1}" } ,
                        { "votifierxp_Creator"," XP Option By http://goo.gl/cz32QX " }
                 

                };
            }
        }

        private void Instance_OnPlayerVoted(UnturnedPlayer player, Votifier.ServiceDefinition definition)
        {
            string XPReceived = Configuration.Instance.XP + "Sup";
            
            player.Experience += Configuration.Instance.XP.Value; 

            UnturnedChat.Say(player, Translate("votifierxp_player_has_voted", definition.Name, XPReceived));
            Logger.Log(player.DisplayName + " has received " + XPReceived +  " because he voted on " + definition.Name);
            UnturnedChat.Say(player, Translate("votifierxp_player_has_voted"));
            Logger.Log("XP Option By http://goo.gl/cz32QX");
              
        }
    }
}
