﻿using System;
using Activator.Base;
using LeagueSharp.Common;

namespace Activator.Items.Consumables
{
    class _2032 : CoreItem
    {
        internal override int Id => 2032;
        internal override int Priority => 3;
        internal override string Name => "Hunter's Pot";
        internal override string DisplayName => "Hunter's Pot";
        internal override int Duration => 101;
        internal override float Range => float.MaxValue;
        internal override MenuType[] Category => new[] { MenuType.SelfLowMP, MenuType.SelfLowHP };
        internal override MapType[] Maps => new[] { MapType.Common };
        internal override int DefaultHP => 65;
        internal override int DefaultMP => 25;

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (hero.Player.HasBuff("ItemCrystalFlaskJungle"))
                        return;

                    if (hero.Player.MaxHealth - hero.Player.Health + hero.IncomeDamage > 120)
                    {
                        if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                            Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                        {
                            if ((hero.IncomeDamage > 0 || hero.MinionDamage > 0 || hero.TowerDamage > 0) ||
                                !Menu.Item("use" + Name + "cbat").GetValue<bool>())
                            {
                                if (!hero.Player.IsRecalling() && !hero.Player.InFountain())
                                    UseItem();
                            }
                        }
                    }

                    if (hero.Player.MaxMana <= 200)
                        continue;

                    if (hero.Player.Mana / hero.Player.MaxMana * 100 <=
                        Menu.Item("selflowmp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (!hero.Player.IsRecalling() && !hero.Player.InFountain())
                            UseItem();
                    }
                }
            }
        }
    }
}
