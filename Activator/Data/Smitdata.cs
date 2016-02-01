#region Copyright � 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/Smitedata.cs
// Date:		22/09/2015
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using System.Collections.Generic;

namespace Activator.Data
{
    public class Smitdata
    {
        public string Name;
        public float CastRange;
        public SpellSlot Slot;
        public int Stage;
        public SpellDataTargetType Type;

        public static List<Smitdata> SpellList = new List<Smitdata>();

        public bool HeroReqs(Obj_AI_Base unit)
        {
            if (unit == null)
                return false;

            switch (Activator.Player.ChampionName)
            {
                case "Twitch":
                    if (!unit.HasBuff("twitchdeadlyvenom"))
                        return false;
                    break;
                case "LeeSin":
                    if (!unit.HasBuff("blindmonkqonechaos"))
                        return false;
                    break;
                case "Diana":
                    if (!unit.HasBuff("dianamoonlight"))
                        return false;
                    break;
                case "Elise":
                    if (Activator.Player.CharData.BaseSkinName != "elisespider")
                        return false;
                    break;
                case "Nidalee":
                    if (Activator.Player.CharData.BaseSkinName == "Nidalee")
                        return false;
                    break;
            }

            return true;
        }

        static Smitdata()
        {
            SpellList.Add(new Smitdata
            {
                Name = "DrMundo",
                CastRange = 500f,
                Stage = 0,
                Type = SpellDataTargetType.Location,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new Smitdata
            {
                Name = "Ekko",
                CastRange = 425f,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.E
            });

            SpellList.Add(new Smitdata
            {
                Name = "Rengar",
                CastRange = 150f,
                Stage = Activator.Player.Mana > 4 ? 1 : 0,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new Smitdata
            {
                Name = "Wukong",
                CastRange = 305f,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new Smitdata
            {
                Name = "Quinn",
                CastRange = 675f,
                Stage = 0,
                Type = SpellDataTargetType.Unit,
                Slot = SpellSlot.E
            });

            SpellList.Add(new Smitdata
            {
                Name = "Fiora",
                CastRange = 375f,
                Stage = 0,
                Type = SpellDataTargetType.Location,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new Smitdata
            {
                Name = "Nidalee",
                CastRange = 375f,
                Stage = 1,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new Smitdata
            {
                Name = "Alistar",
                CastRange = 350f,
                Stage = 0,
                Type = SpellDataTargetType.Self,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new Smitdata
            {
                Name = "FiddleSticks",
                CastRange = 750f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "JarvanIV",
                CastRange = 770f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new Smitdata
            {
                Name = "Twitch",
                CastRange = 950f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new Smitdata
            {
                Name = "Riven",
                CastRange = 150f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new Smitdata
            {
                Name = "Malphite",
                CastRange = 200f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new Smitdata
            {
                Name = "Nunu",
                CastRange = 200f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Olaf",
                CastRange = 325f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Elise",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Warwick",
                CastRange = 400f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Trundle",
                CastRange = 180f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit
            });

            SpellList.Add(new Smitdata
            {
                Name = "MasterYi",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Kayle",
                CastRange = 650f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Khazix",
                CastRange = 325f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "MonkeyKing",
                CastRange = 300f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Darius",
                CastRange = 425f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new Smitdata
            {
                Name = "Diana",
                CastRange = 825f,
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Fizz",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Evelynn",
                CastRange = 225f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });


            SpellList.Add(new Smitdata
            {
                Name = "Maokai",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new Smitdata
            {
                Name = "Nocturne",
                CastRange = 500f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new Smitdata
            {
                Name = "Pantheon",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Volibear",
                CastRange = 400f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Vi",
                CastRange = 125f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Tryndamere",
                CastRange = 400f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new Smitdata
            {
                Name = "Zac",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new Smitdata
            {
                Name = "Shen",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "XinZhao",
                CastRange = 600f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new Smitdata
            {
                Name = "Amumu",
                CastRange = 350f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new Smitdata
            {
                Name = "LeeSin",
                CastRange = 1300f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new Smitdata
            {
                Name = "Chogath",
                CastRange =  175 + new [] { 23f, 37f, 50f} [Activator.Player.Level / 6],
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });
        }
    }
}