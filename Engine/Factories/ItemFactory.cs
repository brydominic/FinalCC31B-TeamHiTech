using Engine.Actions;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            BuildWeapon(1001, "Rifle", 0, "pack://application:,,,/Engine;component/Images/Items/.png", 0, 3);
            BuildWeapon(1002, "Augmented Disruptor", 10, "pack://application:,,,/Engine;component/Images/Items/png", 1, 4);
            BuildWeapon(1003, "Decryptor Device", 50, "pack://application:,,,/Engine;component/Images/Items/.png", 1, 10);
            BuildWeapon(1004, "Flamethrower", 150, "pack://application:,,,/Engine;component/Images/Items/.png", 1, 25);
            BuildWeapon(1005, "Cyber Tracer", 0, "pack://application:,,,/Engine;component/Images/Items/.png", 5, 20);
            BuildWeapon(1006, "Digital Staff", 100, "pack://application:,,,/Engine;component/Images/Items/.png", 4, 10);
            BuildWeapon(1007, "Droid Companion", 0, "pack://application:,,,/Engine;component/Images/Items/.png", 10, 30);
            BuildWeapon(1008, "Cyber Sword", 200, "pack://application:,,,/Engine;component/Images/Items/.png", 1, 15);
            BuildWeapon(1009, "Mecha Amulet", 200, "pack://application:,,,/Engine;component/Images/Items/.png", 3, 13);
            BuildWeapon(1010, "Iron Glove", 200, "pack://application:,,,/Engine;component/Images/Items/.png", 6, 10);

            BuildWeapon(1501, "Mk Rifle", 0, "villainitem", 0, 2);
            BuildWeapon(1502, "Laser Shooters", 0, "villainitem", 0, 3);
            BuildWeapon(1503, "Shockwave", 0, "villainitem", 1, 5);
            BuildWeapon(1504, "Homing Missiles", 0, "villainitem", 4, 12);
            BuildWeapon(1505, "Blast Breath", 0, "villainitem", 5, 15);
            BuildWeapon(1506, "Stealth", 0, "villainitem", 1, 6);
            BuildWeapon(1507, "Pulse Railgun", 0, "villainitem", 10, 15);

            BuildHealingItem(2001, "Medkit", 5, 5, "pack://application:,,,/Engine;component/Images/Items/medkit.png");

            BuildMiscellaneousItem(2501, "Troops Chip", 10, "collectibleonly");
            BuildMiscellaneousItem(2502, "AI Golem Core", 50, "collectibleonly");
            BuildMiscellaneousItem(2503, "Blueprint", 100, "collectibleonly");
            BuildMiscellaneousItem(2504, "Dragon Iron Scale", 300, "collectibleonly");
            BuildMiscellaneousItem(2505, "Stealth Cloak", 50, "collectibleonly");
            BuildMiscellaneousItem(2506, "AI Self Destruct Key", 300, "collectibleonly");

            BuildMiscellaneousItem(3001, "Meds", 5, "collectibleonly");
            BuildMiscellaneousItem(3002, "Shield", 10, "collectibleonly");
            BuildMiscellaneousItem(3003, "Energy", 5, "collectibleonly");


        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price, string imageName)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price, imageName));
        }
        private static void BuildWeapon(int id, string name, int price, string imageName,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, imageName, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal, string imageName)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price, imageName);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }

    }
}
