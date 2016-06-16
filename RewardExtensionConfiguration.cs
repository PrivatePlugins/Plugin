using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a4834833.RewardExtension
{
    public class RewardExtensionConfiguration : IRocketPluginConfiguration
    {
        public uint? XP = null;
        public decimal Money;
        public void LoadDefaults()
        {
            XP = 190;
            Money = 30;
        }
    }
}
