using System;
using System.ComponentModel;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace DrugsMod.Content.Items
{
    // This is a basic item template.
    // Please see tModLoader's ExampleMod for every other example:
    // https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    public class FentPill : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.DrugsMod.hjson' file.
        public override void SetDefaults()
        {
            Item.width = 7;
            Item.height = 7;
            Item.UseSound = SoundID.Item2;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.buffType = ModContent.BuffType<Buffs.FentBuff>();
            Item.buffTime = 2000;
        }

        public override bool? UseItem(Player player)
        {
            // Hurt the player for 10 points
            player.Hurt(PlayerDeathReason.ByCustomReason(player.name + " took too much fentanyl."), 50, 0, false, true);

            return true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
