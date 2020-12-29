using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mod
{
    public class Module : ETGModule
    {
        public static readonly string MOD_NAME = "Guns/Items rename mod";
        public static readonly string VERSION = "0.0.8";
        public static readonly string TEXT_COLOR = "#1919E0";

        public override void Start()
        {
            Gun YariLauncher = PickupObjectDatabase.GetById(16) as Gun;
            YariLauncher.SetName("Yare Yare Launcher");
            YariLauncher.SetShortDescription("Good Grief....");
            PlayerItem AgedBell = PickupObjectDatabase.GetById(237) as PlayerItem;
            AgedBell.SetName("ZA WARUDO");
            AgedBell.SetShortDescription("STOP TIME!");
            Gun BlackHoleGun = PickupObjectDatabase.GetById(169) as Gun;
            BlackHoleGun.SetName("Big succ gun");
            BlackHoleGun.SetShortDescription("S U C C C C C C");
            Gun MakeShiftCannon = PickupObjectDatabase.GetById(480) as Gun;
            MakeShiftCannon.SetName("Hitkill gun");
            Gun Casey = PickupObjectDatabase.GetById(541) as Gun;
            Casey.SetName("Bat + shotgun cartridge");
            Gun WoodBeam = PickupObjectDatabase.GetById(610) as Gun;
            WoodBeam.SetName("Long Wood");
            Gun FlameHand = PickupObjectDatabase.GetById(125) as Gun;
            FlameHand.SetName("Crossfire hurricane");
            Gun Excaliber = PickupObjectDatabase.GetById(377) as Gun;
            Excaliber.SetName("Jonathan's sword");
            PassiveItem ShotGunCoffee = PickupObjectDatabase.GetById(427) as PassiveItem;
            ShotGunCoffee.SetName("Iggy's food");
            PassiveItem GoldenJunk = PickupObjectDatabase.GetById(641) as PassiveItem;
            GoldenJunk.SetName("LIXO D'ORO");
            GoldenJunk.SetShortDescription("*Piano starts*");
            Gun SunlightJavelin = PickupObjectDatabase.GetById(748) as Gun;
            SunlightJavelin.SetName("Hamon");
            Gun Origuni = PickupObjectDatabase.GetById(477) as Gun;
            Origuni.SetName("Gun in a paper");
            PassiveItem PlatinumBullets = PickupObjectDatabase.GetById(627) as PassiveItem;
            PlatinumBullets.SetName("Star Platinum Bullets");
            PlatinumBullets.SetShortDescription("ORA ORA!");
            Gun LightGun = PickupObjectDatabase.GetById(27) as Gun;
            LightGun.SetName("Zapper Light Gun");
            LightGun.SetShortDescription("Good for ducks hunting");
            Log($"{MOD_NAME} v{VERSION} didn't crash etg, hooray", TEXT_COLOR);
        }

        public static void Log(string text, string color = "1919E0")
        {
            ETGModConsole.Log($"<color={color}>{text}</color>");
        }

        public override void Exit() { }
        public override void Init() { }
    }
}
