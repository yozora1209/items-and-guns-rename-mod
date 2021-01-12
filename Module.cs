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
        public static readonly string VERSION = "0.1.2";
        public static readonly string TEXT_COLOR = "#1919E0";

        public override void Start()
        {
            Gun YariLauncher = PickupObjectDatabase.GetById(16) as Gun;
            YariLauncher.SetName("Yare Yare Launcher");
            YariLauncher.SetShortDescription("Good Grief....");
            PlayerItem AgedBell = PickupObjectDatabase.GetById(237) as PlayerItem;
            AgedBell.SetName("ZA WARUDO");
            AgedBell.SetShortDescription("STOP TIME!");
            AgedBell.SetLongDescription("This bell appears to be made of different materials at different times. The mournful tones it emits echo forwards and backwards. Some claim that they can hear it before it rings. It looks like that it was used for some sort of vampire or something...");
            Gun BlackHoleGun = PickupObjectDatabase.GetById(169) as Gun;
            BlackHoleGun.SetName("Big succ gun");
            BlackHoleGun.SetShortDescription("S U C C C C C C");
            Gun MakeShiftCannon = PickupObjectDatabase.GetById(480) as Gun;
            MakeShiftCannon.SetName("Hitkill gun");
            Gun Casey = PickupObjectDatabase.GetById(541) as Gun;
            Casey.SetName("B O N K   B A T");
            Casey.SetShortDescription("Bonking .50");
            Gun WoodBeam = PickupObjectDatabase.GetById(610) as Gun;
            WoodBeam.SetName("Mourning Wooden Beam");
            WoodBeam.SetShortDescription("Erection Intensifies");
            Gun Thompson = PickupObjectDatabase.GetById(2) as Gun;
            Thompson.SetName("Joseph's thompson");
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
            Gun DartGun = PickupObjectDatabase.GetById(24) as Gun;
            DartGun.SetName("It's nerf or nothing");
            Gun Saa = PickupObjectDatabase.GetById(50) as Gun;
            Saa.SetName("SAAS");
            Gun Particulator = PickupObjectDatabase.GetById(228) as Gun;
            Particulator.SetName("Sans gun");
            PlayerItem DoubleVision = PickupObjectDatabase.GetById(168) as PlayerItem;
            DoubleVision.SetName("Vodka");
            DoubleVision.SetShortDescription("Kids, don't drink alchool");
            PlayerItem Box = PickupObjectDatabase.GetById(216) as PlayerItem;
            Box.SetShortDescription("Sneak increased to 100");
            PassiveItem FatBullets = PickupObjectDatabase.GetById(277) as PassiveItem;
            FatBullets.SetShortDescription("P H A T");
            PassiveItem SuperHotWatch = PickupObjectDatabase.GetById(279) as PassiveItem;
            SuperHotWatch.SetShortDescription("Damn das hot");
            PassiveItem Sunglasses = PickupObjectDatabase.GetById(290) as PassiveItem;
            Sunglasses.SetShortDescription("Swaggy glasses");
            Gun AbyssalTentacle = PickupObjectDatabase.GetById(474) as Gun;
            AbyssalTentacle.SetName("Hentai gun");
            AbyssalTentacle.SetShortDescription("Yamete kudasai~");
            Gun Plunger = PickupObjectDatabase.GetById(208) as Gun;
            Plunger.SetName("Corona virus vaccine");
            Plunger.SetShortDescription("haha anti vaxxers go die");
            PlayerItem DuctTape = PickupObjectDatabase.GetById(239) as PlayerItem;
            DuctTape.SetShortDescription("Fixes anything!");
            Gun ThirdPartyController = PickupObjectDatabase.GetById(511) as Gun;
            ThirdPartyController.SetShortDescription("A true gamer's weapon");
            Gun Mailbox = PickupObjectDatabase.GetById(28) as Gun;
            Mailbox.SetShortDescription("You've got a mail!");
            PlayerItem PartiallyEatenCheese = PickupObjectDatabase.GetById(662) as PlayerItem;
            PartiallyEatenCheese.SetName("Pacman cheese edition");
            Gun FinishedGun = PickupObjectDatabase.GetById(762) as Gun;
            FinishedGun.SetShortDescription("More like Shitted gun");
            Gun Blunderbuss = PickupObjectDatabase.GetById(122) as Gun;
            Blunderbuss.SetShortDescription("Shoots shitty bullets");
            PlayerItem Cigarettes = PickupObjectDatabase.GetById(203) as PlayerItem;
            Cigarettes.SetShortDescription("Smoke weed every day");
            PassiveItem Honeycomb = PickupObjectDatabase.GetById(138) as PassiveItem;
            Honeycomb.SetShortDescription("Minecraft 1.15");
            PassiveItem ShelletonKey = PickupObjectDatabase.GetById(166) as PassiveItem;
            ShelletonKey.SetShortDescription("Locks are D E A D to you");
            Gun FrostGiant = PickupObjectDatabase.GetById(387) as Gun;
            FrostGiant.SetName("B I G ice pistol");
            PassiveItem Scattershot = PickupObjectDatabase.GetById(241) as PassiveItem;
            Scattershot.SetLongDescription("More bullets, less damage, STONKS");
            Gun Klobbe = PickupObjectDatabase.GetById(31) as Gun;
            Klobbe.SetShortDescription("Hated by everyone");
            PassiveItem ChickenFlute = PickupObjectDatabase.GetById(572) as PassiveItem;
            ChickenFlute.SetShortDescription("Don't mess with them...");
            PlayerItem BracketKey = PickupObjectDatabase.GetById(439) as PlayerItem;
            BracketKey.SetShortDescription("/kill @e");
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
