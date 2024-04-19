using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader mysterious = new Trader("Mysterious Trader");

            for (int x = 0; x < 50; x++)
            {
                mysterious.AddItemToInventory(ItemFactory.CreateGameItem(3001));
                mysterious.AddItemToInventory(ItemFactory.CreateGameItem(3002));
                mysterious.AddItemToInventory(ItemFactory.CreateGameItem(3003));
            }

            
            Trader mystical = new Trader("Cyber Merchant");
            mystical.AddItemToInventory(ItemFactory.CreateGameItem(1008));
            mystical.AddItemToInventory(ItemFactory.CreateGameItem(1009));
            mystical.AddItemToInventory(ItemFactory.CreateGameItem(1010));
            AddTraderToList(mysterious);
            AddTraderToList(mystical);

        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}