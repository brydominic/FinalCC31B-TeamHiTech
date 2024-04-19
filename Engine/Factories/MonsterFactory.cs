using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster aiDrones =
                        new Monster("AI Drones", "drone.png", 15, 15, 10, 10);
                    aiDrones.CurrentWeapon = ItemFactory.CreateGameItem(1502);
                    return aiDrones;
                case 2:
                    Monster aiGolem =
                        new Monster("AI Golem", "golem.jpg", 40, 40, 20, 30);
                    aiGolem.CurrentWeapon = ItemFactory.CreateGameItem(1503);
                    AddLootItem(aiGolem, 2502, 100);
                    return aiGolem;

                case 3:
                    Monster aiTroops =
                        new Monster("AI Troops", "troops.png", 10, 10, 5, 5);
                    aiTroops.CurrentWeapon = ItemFactory.CreateGameItem(1501);
                    AddLootItem(aiTroops, 2501, 100);
                    return aiTroops;

                case 4:
                    Monster starShip =
                        new Monster("Starship", "ship.webp", 70, 70, 50, 100);
                    starShip.CurrentWeapon = ItemFactory.CreateGameItem(1504);
                    AddLootItem(starShip, 2503, 100);
                    return starShip;

                case 5:
                    Monster quantumDragon =
                        new Monster("Quantum's Pet Dragon", "dragon.webp", 120, 120, 100, 500);
                 quantumDragon.CurrentWeapon = ItemFactory.CreateGameItem(1505);
                    AddLootItem(quantumDragon, 2504, 100);
                    return quantumDragon;

                case 6:
                    Monster phantom =
                        new Monster("AI Phantom", "phantom.jpg", 20, 20, 15, 20);
                    //ghost.CurrentWeapon = ItemFactory./*CreateGameItem*/(1506);
                    AddLootItem(phantom, 2505, 100);
                    return phantom;

                case 7:
                    Monster quantum =
                        new Monster("Quantum", "quantum1.png", 150, 150, 10, 5);
                    quantum.CurrentWeapon = ItemFactory.CreateGameItem(1507);
                    AddLootItem(quantum, 2506, 100);
                    return quantum;


                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
