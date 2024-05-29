using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace DrugsMod.Content.Buffs
{
    public class FentBuff : ModBuff
    {
        public static readonly int DefenseBonus = 45;
        public static readonly int Life = 1000;
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;  // Is it a debuff?
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += DefenseBonus;
            player.statLifeMax2 /= 2;
            player.lifeRegen = 0;
            player.lifeRegenTime = 0;
            player.maxRunSpeed = 1.2f;
        }
    }
}