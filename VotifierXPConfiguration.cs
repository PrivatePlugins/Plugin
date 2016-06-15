using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a4834833.VotifierXP
{
    public class VotifierXPConfiguration : IRocketPluginConfiguration
    {
        public uint? XP = null;
        public decimal RewardAmount;
        public void LoadDefaults()
        {
            XP = 190;
            RewardAmount = 30;
        }
    }
}
